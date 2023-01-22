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
            OperatorVoiceItem[] voices = new OperatorVoiceItem[] { new OperatorVoiceItem("baka", "CN_001", "任命助理", "你好呀博士！") };

            Operator testOperator = new("Baka632",
                                        6,
                                        "baka",
                                        OperatorGender.Male,
                                        new OperatorBirthday(5, 14),
                                        new OperatorClass(OperatorMainClass.Supporter, OperatorBranchClass.Summoner),
                                        new OperatorIllustrationInfo[] { new OperatorIllustrationInfo("Traveler", "Travel for lights", "baka_travel", OperatorType.Skin, "Baka632") },
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
        public void OperatorsListSerializeAndDeserializeTest()
        {
            OperatorVoiceItem[] voices = new OperatorVoiceItem[] { new OperatorVoiceItem("baka", "CN_001", "任命助理", "你好呀博士！") };

            Operator testOperator1 = new(
                    "Baka632",
                    6,
                    "baka",
                    OperatorGender.Male,
                    new OperatorBirthday(5, 14),
                    new OperatorClass(OperatorMainClass.Supporter, OperatorBranchClass.Summoner),
                    new OperatorIllustrationInfo[] { new OperatorIllustrationInfo("Traveler", "Travel for lights", "baka_travel", OperatorType.Skin, "Baka632") },
                    new OperatorVoiceInfo[] { new OperatorVoiceInfo("Baka632", OperatorVoiceType.ChineseMandarin, voices) },
                    new OperatorProfile[] { new OperatorProfile("???", OperatorProfileType.Unknown) }
                );

            Operator testOperator2 = new(
                "ab_ba",
                6,
                "ab",
                OperatorGender.Male,
                new OperatorBirthday(5, 14),
                new OperatorClass(OperatorMainClass.Specialist, OperatorBranchClass.Trapmaster),
                new OperatorIllustrationInfo[] { new OperatorIllustrationInfo("Far", "Faraway", "ab_far", OperatorType.Skin, "Baka632") },
                new OperatorVoiceInfo[] { new OperatorVoiceInfo("Baka632", OperatorVoiceType.ChineseMandarin, voices) },
                new OperatorProfile[] { new OperatorProfile("???", OperatorProfileType.Unknown) }
            );

            Dictionary<string, Operator> opDict = new()
            {
                [testOperator1.Codename] = testOperator1,
                [testOperator2.Codename] = testOperator2
            };
            OperatorsList testList = new(opDict);

            string serializedString;

            using (MemoryStream stream = new())
            {
                stream.Position = 0;
                JsonSerializer.Serialize(stream, testList);
                stream.Position = 0;
                using StreamReader reader = new(stream, Encoding.UTF8);
                serializedString = reader.ReadToEnd();
            }

            OperatorsList? opList = JsonSerializer.Deserialize<OperatorsList>(serializedString);
            Assert.NotNull(opList);

            foreach (var item in testList)
            {
                Assert.Equal(item, opList[item.Codename]);
            }
        }

        [Fact]
        public void OperatorEqualityTest()
        {
            OperatorVoiceItem[] voicesA = new OperatorVoiceItem[] { new OperatorVoiceItem("baka", "CN_001", "任命助理", "你好呀博士！") };

            Operator opA = new("Baka632",
                                        6,
                                        "baka",
                                        OperatorGender.Male,
                                        new OperatorBirthday(5, 14),
                                        new OperatorClass(OperatorMainClass.Supporter, OperatorBranchClass.Summoner),
                                        new OperatorIllustrationInfo[] { new OperatorIllustrationInfo("Traveler", "Travel for lights", "baka_travel", OperatorType.Skin, "Baka632") },
                                        new OperatorVoiceInfo[] { new OperatorVoiceInfo("Baka632", OperatorVoiceType.ChineseMandarin, voicesA) },
                                        new OperatorProfile[] { new OperatorProfile("???", OperatorProfileType.Unknown) });

            OperatorVoiceItem[] voicesB = new OperatorVoiceItem[] { new OperatorVoiceItem("baka", "CN_001", "任命助理", "你好呀博士！") };

            Operator opB = new("Baka632",
                                        6,
                                        "baka",
                                        OperatorGender.Male,
                                        new OperatorBirthday(5, 14),
                                        new OperatorClass(OperatorMainClass.Supporter, OperatorBranchClass.Summoner),
                                        new OperatorIllustrationInfo[] { new OperatorIllustrationInfo("Traveler", "Travel for lights", "baka_travel", OperatorType.Skin, "Baka632") },
                                        new OperatorVoiceInfo[] { new OperatorVoiceInfo("Baka632", OperatorVoiceType.ChineseMandarin, voicesB) },
                                        new OperatorProfile[] { new OperatorProfile("???", OperatorProfileType.Unknown) });

            Assert.Equal(opA, opB);
        }
    }
}