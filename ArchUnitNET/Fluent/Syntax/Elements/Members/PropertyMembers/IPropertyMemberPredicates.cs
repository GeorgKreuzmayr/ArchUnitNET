//  Copyright 2019 Florian Gather <florian.gather@tngtech.com>
// 	Copyright 2019 Paula Ruiz <paularuiz22@gmail.com>
// 	Copyright 2019 Fritz Brandhuber <fritz.brandhuber@tngtech.com>
// 
// 	SPDX-License-Identifier: Apache-2.0

namespace ArchUnitNET.Fluent.Syntax.Elements.Members.PropertyMembers
{
    public interface IPropertyMemberPredicates<out TRuleTypeConjunction> : IMemberPredicates<TRuleTypeConjunction>
    {
        /// <summary>
        ///     Select properties that have a Getter for further analysis.
        /// </summary>
        TRuleTypeConjunction HaveGetter();

        /// <summary>
        ///     Select properties that have a private Getter for further analysis.
        /// </summary>
        TRuleTypeConjunction HavePrivateGetter();

        /// <summary>
        ///     Select properties that have a public Getter for further analysis.
        /// </summary>
        TRuleTypeConjunction HavePublicGetter();

        /// <summary>
        ///     Select properties that have a protected Getter for further analysis.
        /// </summary>
        TRuleTypeConjunction HaveProtectedGetter();

        /// <summary>
        ///     Select properties that have a internal Getter for further analysis.
        /// </summary>
        TRuleTypeConjunction HaveInternalGetter();

        /// <summary>
        ///     Select properties that have a protected internal Getter for further analysis.
        /// </summary>
        TRuleTypeConjunction HaveProtectedInternalGetter();

        /// <summary>
        ///     Select properties that have a private protected Getter for further analysis.
        /// </summary>
        TRuleTypeConjunction HavePrivateProtectedGetter();

        /// <summary>
        ///     Select properties that have a Setter for further analysis.
        /// </summary>
        TRuleTypeConjunction HaveSetter();

        /// <summary>
        ///     Select properties that have a private Setter for further analysis.
        /// </summary>
        TRuleTypeConjunction HavePrivateSetter();

        /// <summary>
        ///     Select properties that have a public Setter for further analysis.
        /// </summary>
        TRuleTypeConjunction HavePublicSetter();

        /// <summary>
        ///     Select properties that have a protected Setter for further analysis.
        /// </summary>
        TRuleTypeConjunction HaveProtectedSetter();

        /// <summary>
        ///     Select properties that have a internal Setter for further analysis.
        /// </summary>
        TRuleTypeConjunction HaveInternalSetter();

        /// <summary>
        ///     Select properties that have a protected internal Setter for further analysis.
        /// </summary>
        TRuleTypeConjunction HaveProtectedInternalSetter();

        /// <summary>
        ///     Select properties that have a private protected Setter for further analysis.
        /// </summary>
        TRuleTypeConjunction HavePrivateProtectedSetter();

        /// <summary>
        ///     Select properties that are virtual for further analysis.
        /// </summary>
        TRuleTypeConjunction AreVirtual();


        // Negations


        /// <summary>
        ///     Select properties that have no Getter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveGetter" />
        /// </summary>
        TRuleTypeConjunction HaveNoGetter();

        /// <summary>
        ///     Select properties that have no private Getter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HavePrivateGetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHavePrivateGetter();

        /// <summary>
        ///     Select properties that have no public Getter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HavePublicGetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHavePublicGetter();

        /// <summary>
        ///     Select properties that have no protected Getter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveProtectedGetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHaveProtectedGetter();

        /// <summary>
        ///     Select properties that have no internal Getter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveInternalGetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHaveInternalGetter();

        /// <summary>
        ///     Select properties that have no protected internal Getter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveProtectedInternalGetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHaveProtectedInternalGetter();

        /// <summary>
        ///     Select properties that have no private protected Getter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HavePrivateProtectedGetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHavePrivateProtectedGetter();

        /// <summary>
        ///     Select properties that have no Setter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveSetter" />
        /// </summary>
        TRuleTypeConjunction HaveNoSetter();

        /// <summary>
        ///     Select properties that have no private Setter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HavePrivateSetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHavePrivateSetter();

        /// <summary>
        ///     Select properties that have no public Setter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HavePublicSetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHavePublicSetter();

        /// <summary>
        ///     Select properties that have no protected Setter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveProtectedSetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHaveProtectedSetter();

        /// <summary>
        ///     Select properties that have no internal Setter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveInternalSetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHaveInternalSetter();

        /// <summary>
        ///     Select properties that have no protected internal Setter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveProtectedInternalSetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHaveProtectedInternalSetter();

        /// <summary>
        ///     Select properties that have no private protected Setter for further analysis.
        ///     <para />
        ///     Negation of <see cref="HavePrivateProtectedSetter" />
        /// </summary>
        TRuleTypeConjunction DoNotHavePrivateProtectedSetter();

        /// <summary>
        ///     Select properties that are not virtual for further analysis.
        /// </summary>
        TRuleTypeConjunction AreNotVirtual();
    }
}