using Google.Cloud.TextToSpeech.V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToSpeech
{
    public class GoogleCloudAPI
    {
        public void TextToSpecch(string texto, string linguagem, string nomeArquivo, string genero, string nomeVoz)
        {
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", "chave.json");
            var client = TextToSpeechClient.Create();
            var input = new SynthesisInput
            {
                Text = texto,
            };

            var voiceSelection = new VoiceSelectionParams
            {
                LanguageCode = linguagem,
                Name = nomeVoz,
                SsmlGender = genero == "F" ? SsmlVoiceGender.Female : SsmlVoiceGender.Male,
            };


            var audioConfig = new AudioConfig
            {
                AudioEncoding = AudioEncoding.Mp3
            };

            var response = client.SynthesizeSpeech(input, voiceSelection, audioConfig);

            using (var output = File.Create($"C:\\Audios\\{nomeArquivo}.mp3"))
            {
                response.AudioContent.WriteTo(output);
            }
        }
    }
}
