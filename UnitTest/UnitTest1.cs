namespace UnitTest
{
    public class Tests
    {
        private WordCountLib.Core core;
        private string file1;
        private string file2;


        [SetUp]
        public void Setup()
        {
            core = new WordCountLib.Core();

            file1 = "Go do that thing that you do so well";
            file2 = "I play football well";

        }

        [Test]
        public void ARE_THERE_4_WORDS()
        {
            var foundwords = core.AddText(file2);
            Assert.True(foundwords == 4);
        }

        [Test]
        public void THERE_ARE_NOT_4_WORDS()
        {
            var foundwords = core.AddText(file1);
            Assert.True(foundwords != 4);
        }

        [Test]
        public void WORD_ARE_2_TIMES()
        {
            core.AddText(file1);
            core.AddText(file2);

            var findword = core.Count("well");

            Assert.True(findword == 2);
        }
    }
}