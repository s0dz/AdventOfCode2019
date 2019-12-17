using System.Collections.Generic;
using NUnit.Framework;

namespace AdventOfCode2019.Tests
{
    [TestFixture]
    public class Day1Tests
    {
        // For a mass of 12, divide by 3 and round down to get 4, then subtract 2 to get 2.
        // For a mass of 14, dividing by 3 and rounding down still yields 4, so the fuel required is also 2.
        // For a mass of 1969, the fuel required is 654.
        // For a mass of 100756, the fuel required is 33583.
        [Test]
        public void FuelCounterUpper_Test()
        {
            var result = Day1.FuelCounterUpper(new List<int>{12});
            Assert.AreEqual(2, result);

            result = Day1.FuelCounterUpper(new List<int>{14});
            Assert.AreEqual(2, result);

            result = Day1.FuelCounterUpper(new List<int>{1969});
            Assert.AreEqual(654, result);

            result = Day1.FuelCounterUpper(new List<int>{100756});
            Assert.AreEqual(33583, result);

            result = Day1.FuelCounterUpper(Modules);
            Assert.AreEqual(3287899, result);
        }
        
        public List<int> Modules = new List<int>
        {
            73910,
            57084,
            102852,
            134452,
            108006,
            134228,
            102765,
            60642,
            64819,
            54335,
            82480,
            135119,
            73027,
            107087,
            108254,
            111944,
            83790,
            128585,
            52889,
            53870,
            145120,
            96863,
            57105,
            97702,
            75324,
            70566,
            120914,
            95808,
            86568,
            143498,
            125093,
            71370,
            122889,
            67808,
            133643,
            52806,
            103532,
            126487,
            54807,
            121402,
            57580,
            75759,
            84225,
            102232,
            112367,
            95635,
            132871,
            102903,
            51997,
            74565,
            63674,
            97410,
            96965,
            55711,
            53547,
            117482,
            107957,
            108175,
            136622,
            144235,
            80407,
            78670,
            114870,
            145967,
            148646,
            75955,
            84293,
            129590,
            144067,
            142192,
            79117,
            123861,
            68546,
            148675,
            88932,
            91493,
            127808,
            96517,
            130687,
            137822,
            77726,
            110502,
            130509,
            98370,
            136008,
            142920,
            81358,
            112950,
            101057,
            86547,
            128714,
            135401,
            55903,
            66606,
            105404,
            55276,
            57427,
            101556,
            91111,
            79585
        };
    }
}
