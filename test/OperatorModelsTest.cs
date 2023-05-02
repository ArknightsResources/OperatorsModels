using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Unicode;
using System.Text;

namespace ArknightsResources.Operators.Models.Test
{
    public class OperatorModelsTest
    {
        [Fact]
        public void OperatorSerializeAndDeserializeTest()
        {
            OperatorVoiceLine[] voices = new OperatorVoiceLine[] { new OperatorVoiceLine("baka", "CN_001", "任命助理", "你好呀博士！", OperatorVoiceType.ChineseMandarin) };

            Operator testOperator = new("Baka632",
                                        "baka",
                                        6,
                                        OperatorGender.Male,
                                        new OperatorBirthday(5, 14),
                                        new OperatorClass(OperatorMainClass.Supporter, OperatorBranchClass.Summoner),
                                        new OperatorIllustrationInfo[] { new OperatorIllustrationInfo(OperatorType.Skin, "Traveler", "Travel for lights", "baka_travel", "Baka632",null) },
                                        new OperatorVoiceInfo[] { new OperatorVoiceInfo("Baka632", OperatorVoiceType.ChineseMandarin, voices) },
                                        new OperatorProfile[] { new OperatorProfile("???", OperatorProfileType.Unknown) });
            
            MemoryStream stream = new();
            JsonSerializer.Serialize(stream, testOperator);
            stream.Position = 0;
            Operator? op = JsonSerializer.Deserialize<Operator>(stream, new JsonSerializerOptions()
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                Converters =
                {
                    new JsonStringEnumConverter()
                }
            });

            Assert.Equal(testOperator, op);
        }

        [Fact]
        public void OperatorEqualityTest()
        {
            OperatorVoiceLine[] voicesA = new OperatorVoiceLine[] { new OperatorVoiceLine("baka", "CN_001", "任命助理", "你好呀博士！", OperatorVoiceType.ChineseMandarin) };

            Operator opA = new("Baka632",
                                        "baka",
                                        6,
                                        OperatorGender.Male,
                                        new OperatorBirthday(5, 14),
                                        new OperatorClass(OperatorMainClass.Supporter, OperatorBranchClass.Summoner),
                                        new OperatorIllustrationInfo[] { new OperatorIllustrationInfo(OperatorType.Skin, "Traveler", "Travel for lights", "baka_travel", "Baka632", null) },
                                        new OperatorVoiceInfo[] { new OperatorVoiceInfo("Baka632", OperatorVoiceType.ChineseMandarin, voicesA) },
                                        new OperatorProfile[] { new OperatorProfile("???", OperatorProfileType.Unknown) });

            OperatorVoiceLine[] voicesB = new OperatorVoiceLine[] { new OperatorVoiceLine("baka", "CN_001", "任命助理", "你好呀博士！",OperatorVoiceType.ChineseMandarin) };

            Operator opB = new("Baka632",
                                        "baka",
                                        6,
                                        OperatorGender.Male,
                                        new OperatorBirthday(5, 14),
                                        new OperatorClass(OperatorMainClass.Supporter, OperatorBranchClass.Summoner),
                                        new OperatorIllustrationInfo[] { new OperatorIllustrationInfo(OperatorType.Skin, "Traveler", "Travel for lights", "baka_travel", "Baka632", null) },
                                        new OperatorVoiceInfo[] { new OperatorVoiceInfo("Baka632", OperatorVoiceType.ChineseMandarin, voicesB) },
                                        new OperatorProfile[] { new OperatorProfile("???", OperatorProfileType.Unknown) });

            Assert.Equal(opA, opB);
        }
    }
}