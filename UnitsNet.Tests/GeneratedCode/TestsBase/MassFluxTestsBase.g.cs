﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of MassFlux.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MassFluxTestsBase
    {
        protected abstract double GramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter { get; }
        protected abstract double KilogramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GramsPerSecondPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerSecondPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MassFlux((double)0.0, MassFluxUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new MassFlux();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MassFluxUnit.KilogramPerSecondPerSquareMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MassFlux(double.PositiveInfinity, MassFluxUnit.KilogramPerSecondPerSquareMeter));
            Assert.Throws<ArgumentException>(() => new MassFlux(double.NegativeInfinity, MassFluxUnit.KilogramPerSecondPerSquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MassFlux(double.NaN, MassFluxUnit.KilogramPerSecondPerSquareMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MassFlux(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void MassFlux_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new MassFlux(1, MassFluxUnit.KilogramPerSecondPerSquareMeter);

            QuantityInfo<MassFluxUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(MassFlux.Zero, quantityInfo.Zero);
            Assert.Equal("MassFlux", quantityInfo.Name);
            Assert.Equal(QuantityType.MassFlux, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<MassFluxUnit>().Except(new[] {MassFluxUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void KilogramPerSecondPerSquareMeterToMassFluxUnits()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(GramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeter.GramsPerSecondPerSquareMeter, GramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeter.KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = MassFlux.From(1, MassFluxUnit.GramPerSecondPerSquareMeter);
            AssertEx.EqualTolerance(1, quantity00.GramsPerSecondPerSquareMeter, GramsPerSecondPerSquareMeterTolerance);
            Assert.Equal(MassFluxUnit.GramPerSecondPerSquareMeter, quantity00.Unit);

            var quantity01 = MassFlux.From(1, MassFluxUnit.KilogramPerSecondPerSquareMeter);
            AssertEx.EqualTolerance(1, quantity01.KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            Assert.Equal(MassFluxUnit.KilogramPerSecondPerSquareMeter, quantity01.Unit);

        }

        [Fact]
        public void FromKilogramsPerSecondPerSquareMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MassFlux.FromKilogramsPerSecondPerSquareMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => MassFlux.FromKilogramsPerSecondPerSquareMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilogramsPerSecondPerSquareMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MassFlux.FromKilogramsPerSecondPerSquareMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(GramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeter.As(MassFluxUnit.GramPerSecondPerSquareMeter), GramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeter.As(MassFluxUnit.KilogramPerSecondPerSquareMeter), KilogramsPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);

            var grampersecondpersquaremeterQuantity = kilogrampersecondpersquaremeter.ToUnit(MassFluxUnit.GramPerSecondPerSquareMeter);
            AssertEx.EqualTolerance(GramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, (double)grampersecondpersquaremeterQuantity.Value, GramsPerSecondPerSquareMeterTolerance);
            Assert.Equal(MassFluxUnit.GramPerSecondPerSquareMeter, grampersecondpersquaremeterQuantity.Unit);

            var kilogrampersecondpersquaremeterQuantity = kilogrampersecondpersquaremeter.ToUnit(MassFluxUnit.KilogramPerSecondPerSquareMeter);
            AssertEx.EqualTolerance(KilogramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter, (double)kilogrampersecondpersquaremeterQuantity.Value, KilogramsPerSecondPerSquareMeterTolerance);
            Assert.Equal(MassFluxUnit.KilogramPerSecondPerSquareMeter, kilogrampersecondpersquaremeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(1, MassFlux.FromGramsPerSecondPerSquareMeter(kilogrampersecondpersquaremeter.GramsPerSecondPerSquareMeter).KilogramsPerSecondPerSquareMeter, GramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, MassFlux.FromKilogramsPerSecondPerSquareMeter(kilogrampersecondpersquaremeter.KilogramsPerSecondPerSquareMeter).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MassFlux v = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (MassFlux.FromKilogramsPerSecondPerSquareMeter(3)-v).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (MassFlux.FromKilogramsPerSecondPerSquareMeter(10)/5).KilogramsPerSecondPerSquareMeter, KilogramsPerSecondPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, MassFlux.FromKilogramsPerSecondPerSquareMeter(10)/MassFlux.FromKilogramsPerSecondPerSquareMeter(5), KilogramsPerSecondPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MassFlux oneKilogramPerSecondPerSquareMeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            MassFlux twoKilogramsPerSecondPerSquareMeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(2);

            Assert.True(oneKilogramPerSecondPerSquareMeter < twoKilogramsPerSecondPerSquareMeter);
            Assert.True(oneKilogramPerSecondPerSquareMeter <= twoKilogramsPerSecondPerSquareMeter);
            Assert.True(twoKilogramsPerSecondPerSquareMeter > oneKilogramPerSecondPerSquareMeter);
            Assert.True(twoKilogramsPerSecondPerSquareMeter >= oneKilogramPerSecondPerSquareMeter);

            Assert.False(oneKilogramPerSecondPerSquareMeter > twoKilogramsPerSecondPerSquareMeter);
            Assert.False(oneKilogramPerSecondPerSquareMeter >= twoKilogramsPerSecondPerSquareMeter);
            Assert.False(twoKilogramsPerSecondPerSquareMeter < oneKilogramPerSecondPerSquareMeter);
            Assert.False(twoKilogramsPerSecondPerSquareMeter <= oneKilogramPerSecondPerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.Equal(0, kilogrampersecondpersquaremeter.CompareTo(kilogrampersecondpersquaremeter));
            Assert.True(kilogrampersecondpersquaremeter.CompareTo(MassFlux.Zero) > 0);
            Assert.True(MassFlux.Zero.CompareTo(kilogrampersecondpersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => kilogrampersecondpersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => kilogrampersecondpersquaremeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            var b = MassFlux.FromKilogramsPerSecondPerSquareMeter(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            var b = MassFlux.FromKilogramsPerSecondPerSquareMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.True(v.Equals(MassFlux.FromKilogramsPerSecondPerSquareMeter(1), KilogramsPerSecondPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MassFlux.Zero, KilogramsPerSecondPerSquareMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.False(kilogrampersecondpersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MassFlux kilogrampersecondpersquaremeter = MassFlux.FromKilogramsPerSecondPerSquareMeter(1);
            Assert.False(kilogrampersecondpersquaremeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MassFluxUnit.Undefined, MassFlux.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MassFluxUnit)).Cast<MassFluxUnit>();
            foreach(var unit in units)
            {
                if(unit == MassFluxUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MassFlux.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 g·s⁻¹·m⁻²", new MassFlux(1, MassFluxUnit.GramPerSecondPerSquareMeter).ToString());
                Assert.Equal("1 kg·s⁻¹·m⁻²", new MassFlux(1, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 g·s⁻¹·m⁻²", new MassFlux(1, MassFluxUnit.GramPerSecondPerSquareMeter).ToString(swedishCulture));
            Assert.Equal("1 kg·s⁻¹·m⁻²", new MassFlux(1, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 kg·s⁻¹·m⁻²", new MassFlux(0.123456, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString("s1"));
                Assert.Equal("0.12 kg·s⁻¹·m⁻²", new MassFlux(0.123456, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString("s2"));
                Assert.Equal("0.123 kg·s⁻¹·m⁻²", new MassFlux(0.123456, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString("s3"));
                Assert.Equal("0.1235 kg·s⁻¹·m⁻²", new MassFlux(0.123456, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 kg·s⁻¹·m⁻²", new MassFlux(0.123456, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString("s1", culture));
            Assert.Equal("0.12 kg·s⁻¹·m⁻²", new MassFlux(0.123456, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString("s2", culture));
            Assert.Equal("0.123 kg·s⁻¹·m⁻²", new MassFlux(0.123456, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString("s3", culture));
            Assert.Equal("0.1235 kg·s⁻¹·m⁻²", new MassFlux(0.123456, MassFluxUnit.KilogramPerSecondPerSquareMeter).ToString("s4", culture));
        }
    }
}
