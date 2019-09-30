﻿using System;
using ArchUnitNET.Domain;
using ArchUnitNET.Fluent;
using ArchUnitNET.Fluent.Syntax.Elements.Types;
using Xunit;
using static ArchUnitNET.Fluent.Syntax.ConjunctionFactory;
using static ArchUnitNET.Fluent.ObjectProviderDefinition;

namespace ArchUnitNETTests.Fluent.Syntax
{
    public class ActivatorHandlerTests
    {
        [Fact]
        public void CreateSyntaxElementTest()
        {
            var syntaxElement =
                Create<TypesShouldConjunction, IType>(new ArchRuleCreator<IType>(Types));
            Assert.NotNull(syntaxElement);
            Assert.Equal(typeof(TypesShouldConjunction), syntaxElement.GetType());
        }

        [Fact]
        public void CreateSyntaxElementWithInvalidParametersThrowsExceptionTest()
        {
            Assert.Throws<MissingMethodException>(() =>
                Create<ActivatorHandlerTests, IType>(new ArchRuleCreator<IType>(Types)));
        }
    }
}