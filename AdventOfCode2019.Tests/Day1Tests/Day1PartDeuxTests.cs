using System.Collections.Generic;
using AdventOfCode2019.Day1;
using NUnit.Framework;

namespace AdventOfCode2019.Tests.Day1Tests
{
    [TestFixture]
    public class Day1PartDeuxTests
    {
        // 1) A module of mass 14 requires 2 fuel.
        //    This fuel requires no further fuel (2 divided by 3 and rounded down is 0, which would call for a negative fuel),
        //    so the total fuel required is still just 2.
        // 2) At first, a module of mass 1969 requires 654 fuel.Then, this fuel requires 216 more fuel(654 / 3 - 2).
        //    216 then requires 70 more fuel, which requires 21 fuel, which requires 5 fuel, which requires no further fuel.
        //    So, the total fuel required for a module of mass 1969 is 654 + 216 + 70 + 21 + 5 = 966.
        // 3) The fuel required by a module of mass 100756 and its fuel is: 33583 + 11192 + 3728 + 1240 + 411 + 135 + 43 + 12 + 2 = 50346.
        [Test]
        public void FuelCounterUpper_Test()
        {
            var result = Day1PartDeux.FuelCounterUpper(new List<int> { 14 });
            Assert.AreEqual(2, result);

            result = Day1PartDeux.FuelCounterUpper(new List<int> { 1969 });
            Assert.AreEqual(966, result);

            result = Day1PartDeux.FuelCounterUpper(new List<int> { 100756 });
            Assert.AreEqual(50346, result);

            result = Day1PartDeux.FuelCounterUpper(Modules);
            Assert.AreEqual(4928963, result);
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
