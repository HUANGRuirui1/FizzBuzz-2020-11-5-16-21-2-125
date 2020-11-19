using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Should_FizzBuzz_Return_1_Given_1()
        {
            //given
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();
            //when
            string actual = fizzBuzz.Say(1);
            string expected = "1";
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_FizzBuzz_Return_2_Given_2()
        {
            //given
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();
            //when
            string actual = fizzBuzz.Say(2);
            string expected = "2";
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_FizzBuzz_Return_Fizz_Given_3()
        {
            //given
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();
            //when
            string actual = fizzBuzz.Say(3);
            string expected = "Fizz";
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_FizzBuzz_Return_Buzz_Given_5()
        {
            //given
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();
            //when
            string actual = fizzBuzz.Say(5);
            string expected = "Buzz";
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_FizzBuzz_Return_Whizz_Given_7()
        {
            //given
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();
            //when
            string actual = fizzBuzz.Say(7);
            string expected = "Whizz";
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_FizzBuzz_Return_FizzBuzz_Given_15()
        {
            //given
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();
            //when
            string actual = fizzBuzz.Say(15);
            string expected = "FizzBuzz";
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_FizzBuzz_Return_BuzzWhizz_Given_35()
        {
            //given
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();
            //when
            string actual = fizzBuzz.Say(35);
            string expected = "BuzzWhizz";
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_FizzBuzz_Return_FizzWhizz_Given_21()
        {
            //given
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();
            //when
            string actual = fizzBuzz.Say(21);
            string expected = "FizzWhizz";
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_FizzBuzz_Return_FizzBuzzWhizz_Given_105()
        {
            //given
            FizzBuzzGame fizzBuzz = new FizzBuzzGame();
            //when
            string actual = fizzBuzz.Say(105);
            string expected = "FizzBuzzWhizz";
            //then
            Assert.Equal(actual, expected);
        }
    }
}