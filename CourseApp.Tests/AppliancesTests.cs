﻿using System;
using Xunit;

namespace CourseApp.Tests
{
    public class AppliancesTests
    {
        [Fact]
        public void TestEmptyConstructorTvAppliances()
        {
            var item = new TvAppliance();

            Assert.Equal(" ", item.Nazvanie);
            Assert.Equal("untitled", item.Marka);
            Assert.Equal(220, item.Voltage);
            Assert.Equal(1, item.Warranty);
            Assert.Equal(1, item.ChanelNumber);
        }

        [Fact]
        public void TestEmptyConstructorClockAppliances()
        {
            var item = new СlockAppliance();

            Assert.Equal(" ", item.Nazvanie);
            Assert.Equal("untitled", item.Marka);
            Assert.Equal(220, item.Voltage);
            Assert.Equal(1, item.Warranty);
            Assert.Equal(new DateTime(2000, 11, 23), item.Time2);
        }

        [Fact]
        public void TvApplianceTest1()
        {
            Appliances televizor = new TvAppliance("TV", "Samsung", 5, 220);
            televizor.Broke();
            Assert.Equal("Your Appliance is broken", televizor.Broke());
        }

        [Fact]
        public void TvApplianceTest2()
        {
            Appliances televizor = new TvAppliance("TV", "Samsung", 220, 5);
            televizor.BuyNew(televizor);
            Assert.Equal("TV", televizor.Nazvanie);
            Assert.Equal(220, televizor.Voltage);
            Assert.Equal(5, televizor.Warranty);
            Assert.Equal("Samsung", televizor.Marka);
        }

        [Fact]
        public void TestEmptyConstructorСlockAppliance()
        {
            var item = new СlockAppliance();
            Assert.Equal(new DateTime(2000, 11, 23), item.Time2);
            Assert.Equal("untitled", item.Marka);
            Assert.Equal(220, item.Voltage);
            Assert.Equal(1, item.Warranty);
        }

        [Fact]
        public void СlockApplianceTest1()
        {
            Appliances clockAppliance = new СlockAppliance("clock", "samsung", 220, 2, new DateTime(2000, 11, 23));
            clockAppliance.Broke();
            Assert.Equal("Your Appliance is broken", clockAppliance.Broke());
        }

        [Fact]
        public void СlockApplianceTest2()
        {
            Appliances clockAppliance = new СlockAppliance("clock", "samsung", 220, 2, new DateTime(2000, 11, 23));
            clockAppliance.BuyNew(clockAppliance);
            Assert.Equal("samsung", clockAppliance.Marka);
            Assert.Equal(220, clockAppliance.Voltage);
            Assert.Equal(2, clockAppliance.Warranty);
        }

        [Fact]
        public void TestIncorrectSetTvVoltage()
        {
            try
            {
                var item = new TvAppliance();
                item.Voltage = -8;
            }
            catch (System.Exception)
            {
                Console.WriteLine("You Appliances willn't work");
                Assert.True(true);
            }
        }

        [Fact]
        public void TestIncorrectSetClockVoltage()
        {
            try
            {
                var item = new СlockAppliance();
                item.Voltage = -8;
            }
            catch (System.Exception)
            {
                Console.WriteLine("You Appliances willn't work");
                Assert.True(true);
            }
        }
    }
}