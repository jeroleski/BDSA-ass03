using System;
using Xunit;

namespace BDSA2020.Assignment3.Tests
{
    public class DelegatesTests
    {
        [Fact]
        public void Delegates_ReverseOrder_given_dlrow_olleh_returns_hello_world()
        {
            var input = "dlrow olleh";

            var reverser = Delegates.GetReverseOrder();
            var output = reverser(input);

            var expected = "hello world";
            Assert.Equal(expected, output);
        }

        [Fact]
        public void Delegates_producter_given_3_5_returns_15()
        {
            var a = 3;
            var b = 5;

            var func = Delegates.producter;
            var result = func(a, b);

            var expected = 15;
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Delegates_numberValidator_given_42_0042_returns_true()
        {
            var i = 42;
            var s = " 0042";

            Delegates.InitiateNumberValidator();
            var validator = Delegates.numberValidator;
            var isValidated = validator(i, s);

            Assert.True(isValidated);
        }

        [Fact]
        public void Delegates_numberValidator_given_102_102_returns_true()
        {
            var i = 102;
            var s = "102";

            Delegates.InitiateNumberValidator();
            var validator = Delegates.numberValidator;
            var isValidated = validator(i, s);

            Assert.True(isValidated);
        }

        [Fact]
        public void Delegates_numberValidator_given_69_gutenTag_returns_false()
        {
            var i = 69;
            var s = "guten tag";

            Delegates.InitiateNumberValidator();
            var validator = Delegates.numberValidator;
            var isValidated = validator(i, s);

            Assert.False(isValidated);
        }
    }
}
