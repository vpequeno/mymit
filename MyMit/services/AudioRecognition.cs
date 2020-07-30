using System;
using System.Threading.Tasks;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;

namespace MyMit.services
{
    public class AudioRecognition
    {
        public string result_text { get; set; }

        public async Task convertAudioAsync(string path)
        {
            await RecognizeSpeechAsync(path);
            Console.WriteLine(result_text);
        }

        public async Task RecognizeSpeechAsync(string path)
        {
            try
            {
                var config = SpeechConfig.FromSubscription("523e137d4e544865b41b7b418dd39ac0", "uksouth");
                config.SpeechRecognitionLanguage = "pt-PT";

                using (var audioInput = AudioConfig.FromWavFileInput(path))
                using (var recognizer = new SpeechRecognizer(config, audioInput))
                {
                    Console.WriteLine("Recognizing first result...");
                    var result = await recognizer.RecognizeOnceAsync();

                    switch (result.Reason)
                    {
                        case ResultReason.RecognizedSpeech:
                            this.result_text = result.Text;
                            break;
                        case ResultReason.NoMatch:
                            this.result_text = "NOMATCH: Speech could not be recognized.";
                            break;
                        case ResultReason.Canceled:
                            var cancellation = CancellationDetails.FromResult(result);
                            Console.WriteLine($"CANCELED: Reason={cancellation.Reason}");
                            this.result_text = "CANCELED: Reason={cancellation.Reason}";
                            if (cancellation.Reason == CancellationReason.Error)
                            {
                                Console.WriteLine($"CANCELED: ErrorCode={cancellation.ErrorCode}");
                                Console.WriteLine($"CANCELED: ErrorDetails={cancellation.ErrorDetails}");
                                Console.WriteLine($"CANCELED: Did you update the subscription info?");
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}