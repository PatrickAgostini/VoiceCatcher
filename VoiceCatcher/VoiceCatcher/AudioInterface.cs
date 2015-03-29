/*
 * Created by SharpDevelop.
 * User: HO-Audio
 * Date: 19.03.2015
 * Time: 15:37
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Threading;
using System.Collections.Generic;
using System.Collections;
using NAudio;
using NAudio.Wave;
using NAudio.WindowsMediaFormat;

namespace VoiceCatcher
{
	/// <summary>
	/// Description of AudioInterface.
	/// </summary>
	/// 
	public partial class AudioInterface
	{
		// Recording Device Name
		String REC_DEV_NAME = "Mikrofon (2- Logitech USB Heads";
		
		// Recording Interface
		int            deviceIndex;
		WaveIn         recorder;
		
		// Buffers
		byte[]     ringBuffer;
		List<byte> audioBuffer;
		int        ringPointer=0;
		
		// Levelmeter
		Action<int> levelCallback;
		Action<float> callback;
		
		// Status Flags
		bool isRecording = false;
		int typeRecording;
		
		float[] prevBuffer;
		float sampleRate = 8000;
		int N          = 1024;
		float maxOffset;
		float minOffset;
		
		public AudioInterface(Action<int> callback, Action<float> callback2)
		{
			this.levelCallback = callback;
			this.callback = callback2;
			InitAudioDevices();
		}
		
		public void InitAudioDevices()
		{
			this.recorder = new WaveIn();
			this.recorder.DataAvailable += RecorderOnDataAvailable;
			this.recorder.StartRecording();
		}
		
		private void RecorderOnDataAvailable(object sender, WaveInEventArgs waveInEventArgs)
		{
			if(this.isRecording)
			{
				switch(this.typeRecording)
				{
					case 0:
						this.fillAudioBuffer(waveInEventArgs);
						break;
					case 1:
						this.fillRingBuffer(waveInEventArgs);
						break;
				}
			}
			this.levelCallback(Convert.ToInt16(RMS(waveInEventArgs.Buffer)));
		}
		
		public void startRecording(int flag, int duration)
		{
			switch(flag)
			{
				case 0:
					this.audioBuffer = new List<byte>();
					this.ringBuffer  = null;
					break;
				case 1:
					this.audioBuffer = null;
					this.ringBuffer  = this.ringBuffer = new byte[duration*this.recorder.WaveFormat.SampleRate];
					this.ringPointer = 0;
					break;
			}
			this.isRecording = true;
			this.typeRecording = flag;
		}
		
		public void stopRecording()
		{
			this.isRecording = false;
		}
		
		public void saveRecording(String path)
		{
			WaveFileWriter writer = new WaveFileWriter(path, this.recorder.WaveFormat);
			switch(this.typeRecording)
			{
				case 0:
					byte[] audioData = this.audioBuffer.ToArray();
					writer.Write(audioData, 0, audioData.Length);
					break;
				case 1:
					writer.Write(this.ringBuffer, 0 , this.ringBuffer.Length);
					break;
			}
			writer.Dispose();
		}
		
		private void fillAudioBuffer(WaveInEventArgs waveInEventArgs)
		{
			if(this.audioBuffer!=null)
			{
				this.audioBuffer.AddRange(waveInEventArgs.Buffer);
			}
		}
		
		private void fillRingBuffer(WaveInEventArgs waveInEventArgs)
		{
			if(this.ringBuffer!=null)
			{
				for(int i = 0;i<waveInEventArgs.Buffer.Length;i++)
				{
					this.ringBuffer[this.ringPointer] = waveInEventArgs.Buffer[i];
					this.ringPointer = (this.ringPointer+1) % this.ringBuffer.Length;
				}
			}
		}
		
		private bool checkDeviceConnected()
		{
			if(this.getCap())
			{
				this.InitAudioDevices();
				return true;
			}
			return false;
		}

		private bool getCap()
		{
			List<WaveInCapabilities> sources = new List<WaveInCapabilities>();
			for (int i = 0; i < NAudio.Wave.WaveIn.DeviceCount; i++)
			{
				sources.Add(NAudio.Wave.WaveIn.GetCapabilities(i));
			}
			
			for(int i=0;i<sources.Count;i++)
			{
				if(sources[i].ProductName==this.REC_DEV_NAME)
				{
					this.deviceIndex = i;
					return true;
				}
			}
			return false;
		}
		
		public double RMS(byte[] values)
		{
			short[] sampleData = new short[values.Length/2];
			Buffer.BlockCopy(values, 0, sampleData, 0, values.Length);
			double s = 0;
			int i;
			for (i = 0; i < sampleData.Length; i++)
			{
				s += sampleData[i]*sampleData[i];
			}
			s/= values.Length;
			return  NAudio.Utils.Decibels.LinearToDecibels(Math.Sqrt(s))-40;
		}
		
		public void AutoCorrelator(int sampleRate)
		{
			this.sampleRate = (float)sampleRate;
			int minFreq = 85;
			int maxFreq = 255;

			this.maxOffset = sampleRate / minFreq;
			this.minOffset = sampleRate / maxFreq;
		}
		
		
	}
}
