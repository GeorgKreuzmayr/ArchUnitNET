//  Copyright 2019 Florian Gather <florian.gather@tngtech.com>
// 	Copyright 2019 Paula Ruiz <paularuiz22@gmail.com>
// 	Copyright 2019 Fritz Brandhuber <fritz.brandhuber@tngtech.com>
// 
// 	SPDX-License-Identifier: Apache-2.0

using System;
using System.Collections.Generic;
using ArchUnitNET.Domain;

namespace ArchUnitNET.Fluent.Syntax.Elements.Members.MethodMembers
{
    public interface IMethodMemberPredicates<out TRuleTypeConjunction> : IMemberPredicates<TRuleTypeConjunction>
    {
        /// <summary>
        ///     Select methods that are constructors for further analysis.
        /// </summary>
        TRuleTypeConjunction AreConstructors();

        /// <summary>
        ///     Select methods that are virtual for further analysis.
        /// </summary>
        TRuleTypeConjunction AreVirtual();

        /// <summary>
        ///     Select methods that are called by types with full name containing <paramref name="pattern" /> for further analysis.
        ///     <para />
        ///     The <paramref name="pattern" /> has to match full name of type if <paramref name="useRegularExpressions" />=true.
        /// </summary>
        /// <param name="pattern">A pattern to match full names of the types</param>
        /// <param name="useRegularExpressions">option if names have to match or contain <paramref name="pattern" /></param>
        TRuleTypeConjunction AreCalledBy(string pattern, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that are called by types with full name containing one string in <paramref name="patterns" /> for
        ///     further analysis.
        ///     <para />
        ///     One element in <paramref name="patterns" /> has to match full name of type if
        ///     <paramref name="useRegularExpressions" />=true.
        /// </summary>
        /// <param name="patterns">Patterns to match full names of the types</param>
        /// <param name="useRegularExpressions">
        ///     option if names have to match or contain one element in
        ///     <paramref name="patterns" />
        /// </param>
        TRuleTypeConjunction AreCalledBy(IEnumerable<string> patterns, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that are called by <see cref="ArchUnitNET.Domain.IType" /> <paramref name="firstType" /> or
        ///     <paramref name="moreTypes" /> for further analysis.
        /// </summary>
        /// <param name="firstType"><see cref="IType" /> by which methods are called</param>
        /// <param name="moreTypes">More <see cref="IType" /> objects by which methods are called</param>
        TRuleTypeConjunction AreCalledBy(IType firstType, params IType[] moreTypes);

        /// <summary>
        ///     Select methods that are called by <see cref="System.Type" /> <paramref name="type" /> or
        ///     <paramref name="moreTypes" />
        ///     for further analysis.
        /// </summary>
        /// <param name="type"><see cref="Type" /> by which methods are called</param>
        /// <param name="moreTypes">More <see cref="Type" /> objects by which methods are called</param>
        TRuleTypeConjunction AreCalledBy(Type type, params Type[] moreTypes);

        /// <summary>
        ///     Select methods that are called by one element in <see cref="IObjectProvider{T}" /> <paramref name="types" /> for
        ///     further analysis.
        /// </summary>
        /// <param name="types"><see cref="IObjectProvider{T}" /> of <see cref="IType" /> objects by which methods are called</param>
        TRuleTypeConjunction AreCalledBy(IObjectProvider<IType> types);

        /// <summary>
        ///     Select methods that are called by one <see cref="IType" /> in <paramref name="types" /> for further analysis.
        /// </summary>
        /// <param name="types"><see cref="IType" /> by which methods are called</param>
        TRuleTypeConjunction AreCalledBy(IEnumerable<IType> types);

        /// <summary>
        ///     Select methods that are called by one <see cref="Type" /> in <paramref name="types" /> for further analysis.
        /// </summary>
        /// <param name="types"><see cref="Type" /> by which methods are called</param>
        TRuleTypeConjunction AreCalledBy(IEnumerable<Type> types);

        /// <summary>
        ///     Select methods that have dependency in method body to types with full name containing <paramref name="pattern" />
        ///     for
        ///     further analysis.
        ///     <para />
        ///     The <paramref name="pattern" /> has to match full name of type if <paramref name="useRegularExpressions" />=true.
        /// </summary>
        /// <param name="pattern">A pattern for the full names of the types</param>
        /// <param name="useRegularExpressions">option if name has to match or contain <paramref name="pattern" /></param>
        TRuleTypeConjunction HaveDependencyInMethodBodyTo(string pattern, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that have dependency in method body to types with full name containing one string in
        ///     <paramref name="patterns" /> for further analysis.
        ///     <para />
        ///     One element in  <paramref name="patterns" /> has to match full name of type if
        ///     <paramref name="useRegularExpressions" />=true.
        /// </summary>
        /// <param name="patterns">Patterns for the full names of the types</param>
        /// <param name="useRegularExpressions">option if name has to match or contain <paramref name="patterns" /></param>
        TRuleTypeConjunction HaveDependencyInMethodBodyTo(IEnumerable<string> patterns,
            bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that have dependency in method body to <see cref="ArchUnitNET.Domain.IType" />
        ///     <paramref name="firstType" /> or <paramref name="moreTypes" /> for further analysis.
        /// </summary>
        /// <param name="firstType"><see cref="IType" /> to which method body has dependency to</param>
        /// <param name="moreTypes">More <see cref="IType" /> objects to which method body has dependency to</param>
        TRuleTypeConjunction HaveDependencyInMethodBodyTo(IType firstType, params IType[] moreTypes);

        /// <summary>
        ///     Select methods that have dependency in method body to <see cref="System.Type" /> <paramref name="type" /> or
        ///     <paramref name="moreTypes" /> for further analysis.
        /// </summary>
        /// <param name="type"><see cref="Type" /> to which method body has dependency to</param>
        /// <param name="moreTypes">More <see cref="Type" /> objects to which method body has dependency to</param>
        TRuleTypeConjunction HaveDependencyInMethodBodyTo(Type type, params Type[] moreTypes);

        /// <summary>
        ///     Select methods that have dependency in method body to one element in <see cref="IObjectProvider{T}" />
        ///     <paramref name="types" /> for further analysis.
        /// </summary>
        /// <param name="types"><see cref="IType" /> to which method body has dependency to</param>
        TRuleTypeConjunction HaveDependencyInMethodBodyTo(IObjectProvider<IType> types);

        /// <summary>
        ///     Select methods that have dependency in method body to one <see cref="IType" /> in <paramref name="types" /> for
        ///     further analysis.
        /// </summary>
        /// <param name="types"><see cref="IType" /> to which method body has dependency to</param>
        TRuleTypeConjunction HaveDependencyInMethodBodyTo(IEnumerable<IType> types);

        /// <summary>
        ///     Select methods that have dependency in method body to one <see cref="Type" /> in <paramref name="types" /> for
        ///     further
        ///     analysis.
        /// </summary>
        /// <param name="types"><see cref="Type" /> to which method body has dependency to</param>
        TRuleTypeConjunction HaveDependencyInMethodBodyTo(IEnumerable<Type> types);

        /// <summary>
        ///     Select methods that have return type with full name containing <paramref name="pattern" /> for further analysis.
        ///     <para />
        ///     The <paramref name="pattern" /> has to match full name of return type if <paramref name="useRegularExpressions" />
        ///     =true.
        /// </summary>
        /// <param name="pattern">A pattern to match full names of return types</param>
        /// <param name="useRegularExpressions">option if names have to match or contain <paramref name="pattern" /></param>
        TRuleTypeConjunction HaveReturnType(string pattern, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that have return type with full name containing one string in <paramref name="patterns" /> for
        ///     further
        ///     analysis.
        ///     <para />
        ///     One element in <paramref name="patterns" /> has to match full name of return type if
        ///     <paramref name="useRegularExpressions" />=true.
        /// </summary>
        /// <param name="patterns">Patterns to match full names of return types</param>
        /// <param name="useRegularExpressions">
        ///     option if names have to match or contain one element in
        ///     <paramref name="patterns" />
        /// </param>
        TRuleTypeConjunction HaveReturnType(IEnumerable<string> patterns, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that have return type <paramref name="firstType" /> or <paramref name="moreTypes" /> for further
        ///     analysis.
        /// </summary>
        /// <param name="firstType"><see cref="IType" /> return type of methods</param>
        /// <param name="moreTypes">More <see cref="IType" /> return types of methods</param>
        TRuleTypeConjunction HaveReturnType(IType firstType, params IType[] moreTypes);

        /// <summary>
        ///     Select methods that have return type in <paramref name="types" /> for further analysis.
        /// </summary>
        /// <param name="types"><see cref="IType" /> return types of methods</param>
        TRuleTypeConjunction HaveReturnType(IEnumerable<IType> types);

        /// <summary>
        ///     Select methods that return one element in <see cref="IObjectProvider{T}" /> <paramref name="types" /> for further
        ///     analysis.
        /// </summary>
        /// <param name="types"><see cref="IObjectProvider{T}" /> of return types of methods</param>
        TRuleTypeConjunction HaveReturnType(IObjectProvider<IType> types);

        /// <summary>
        ///     Select methods that have return type <paramref name="type" /> or <paramref name="moreTypes" /> for further
        ///     analysis.
        /// </summary>
        /// <param name="type"><see cref="Type" /> return type of methods</param>
        /// <param name="moreTypes">More <see cref="Type" /> return types of methods</param>
        TRuleTypeConjunction HaveReturnType(Type type, params Type[] moreTypes);

        /// <summary>
        ///     Select methods that have return type in <paramref name="types" /> for further analysis.
        /// </summary>
        /// <param name="types"><see cref="Type" /> return types of methods</param>
        TRuleTypeConjunction HaveReturnType(IEnumerable<Type> types);


        //Negations

        /// <summary>
        ///     Select methods that are no constructors for further analysis.
        ///     <para />
        ///     Negation of <see cref="AreConstructors" />
        /// </summary>
        TRuleTypeConjunction AreNoConstructors();

        /// <summary>
        ///     Select methods that are not virtual for further analysis.
        ///     <para />
        ///     Negation of <see cref="AreVirtual" />
        /// </summary>
        TRuleTypeConjunction AreNotVirtual();

        /// <summary>
        ///     Select methods that are not called by types with full name containing <paramref name="pattern" /> for further
        ///     analysis.
        ///     <para />
        ///     The <paramref name="pattern" /> must not match full name of type if <paramref name="useRegularExpressions" />=true.
        ///     <para />
        ///     Negation of <see cref="AreCalledBy(string,bool)" />
        /// </summary>
        /// <param name="pattern">A pattern to match full names of the types</param>
        /// <param name="useRegularExpressions">option if names have to match or contain <paramref name="pattern" /></param>
        TRuleTypeConjunction AreNotCalledBy(string pattern, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that are not called by types with full name containing any string in <paramref name="patterns" />
        ///     for
        ///     further analysis.
        ///     <para />
        ///     No element in <paramref name="patterns" /> must match full name of type if
        ///     <paramref name="useRegularExpressions" />=true.
        ///     <para />
        ///     Negation of <see cref="AreCalledBy(IEnumerable{string}, bool)" />
        /// </summary>
        /// <param name="patterns">Patterns to match full names of the types</param>
        /// <param name="useRegularExpressions">
        ///     option if names have to match or contain one element in
        ///     <paramref name="patterns" />
        /// </param>
        TRuleTypeConjunction AreNotCalledBy(IEnumerable<string> patterns, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that are not called by <see cref="ArchUnitNET.Domain.IType" /> <paramref name="firstType" /> or
        ///     <paramref name="moreTypes" /> for further analysis.
        ///     <para />
        ///     Negation of <see cref="AreCalledBy(IType, IType[])" />
        /// </summary>
        /// <param name="firstType"><see cref="IType" /> by which methods are not called</param>
        /// <param name="moreTypes">More <see cref="IType" /> objects by which methods are not called</param>
        TRuleTypeConjunction AreNotCalledBy(IType firstType, params IType[] moreTypes);

        /// <summary>
        ///     Select methods that are not called by <see cref="System.Type" /> <paramref name="type" /> or
        ///     <paramref name="moreTypes" /> for further analysis.
        ///     <para />
        ///     Negation of <see cref="AreCalledBy(Type, Type[])" />
        /// </summary>
        /// <param name="type"><see cref="Type" /> by which methods are not called</param>
        /// <param name="moreTypes">More <see cref="Type" /> objects by which methods are not called</param>
        TRuleTypeConjunction AreNotCalledBy(Type type, params Type[] moreTypes);

        /// <summary>
        ///     Select methods that are not called by any element in <see cref="IObjectProvider{T}" /> <paramref name="types" />
        ///     for
        ///     further analysis.
        ///     <para />
        ///     Negation of <see cref="AreCalledBy(IObjectProvider{IType})" />
        /// </summary>
        /// <param name="types"><see cref="IObjectProvider{T}" /> of <see cref="IType" /> objects by which methods are not called</param>
        TRuleTypeConjunction AreNotCalledBy(IObjectProvider<IType> types);

        /// <summary>
        ///     Select methods that are not called by any <see cref="IType" /> in <paramref name="types" /> for further analysis.
        ///     <para />
        ///     Negation of <see cref="AreCalledBy(IEnumerable{IType})" />
        /// </summary>
        /// <param name="types"><see cref="IType" /> by which methods are not called</param>
        TRuleTypeConjunction AreNotCalledBy(IEnumerable<IType> types);

        /// <summary>
        ///     Select methods that are not called by any <see cref="Type" /> in <paramref name="types" /> for further analysis.
        ///     <para />
        ///     Negation of <see cref="AreNotCalledBy(IEnumerable{Type})" />
        /// </summary>
        /// <param name="types"><see cref="Type" /> by which methods are not called</param>
        TRuleTypeConjunction AreNotCalledBy(IEnumerable<Type> types);

        /// <summary>
        ///     Select methods that have no dependency in method body to types with full name containing
        ///     <paramref name="pattern" />
        ///     for further analysis.
        ///     <para />
        ///     The <paramref name="pattern" /> must not match full name of type if <paramref name="useRegularExpressions" />=true.
        ///     <para />
        ///     Negation of <see cref="HaveDependencyInMethodBodyTo(string,bool)" />
        /// </summary>
        /// <param name="pattern">A pattern for the full names of the types</param>
        /// <param name="useRegularExpressions">option if name has to match or contain <paramref name="pattern" /></param>
        TRuleTypeConjunction DoNotHaveDependencyInMethodBodyTo(string pattern, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that have no dependency in method body to types with full name containing any string in
        ///     <paramref name="patterns" /> for further analysis.
        ///     <para />
        ///     No element in  <paramref name="patterns" /> must match full name of type if
        ///     <paramref name="useRegularExpressions" />=true.
        ///     <para />
        ///     Negation of <see cref="HaveDependencyInMethodBodyTo(IEnumerable{string}, bool)" />
        /// </summary>
        /// <param name="patterns">Patterns for the full names of the types</param>
        /// <param name="useRegularExpressions">option if name has to match or contain <paramref name="patterns" /></param>
        TRuleTypeConjunction DoNotHaveDependencyInMethodBodyTo(IEnumerable<string> patterns,
            bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that have no dependency in method body to <see cref="ArchUnitNET.Domain.IType" />
        ///     <paramref name="firstType" /> or <paramref name="moreTypes" /> for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveDependencyInMethodBodyTo(IType, IType[])" />
        /// </summary>
        /// <param name="firstType"><see cref="IType" /> to which method body must not have dependency to</param>
        /// <param name="moreTypes">More <see cref="IType" /> objects to which method body must not have dependency to</param>
        TRuleTypeConjunction DoNotHaveDependencyInMethodBodyTo(IType firstType, params IType[] moreTypes);

        /// <summary>
        ///     Select methods that have no dependency in method body to <see cref="System.Type" /> <paramref name="type" /> or
        ///     <paramref name="moreTypes" /> for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveDependencyInMethodBodyTo(Type, Type[])" />
        /// </summary>
        /// <param name="type"><see cref="Type" /> to which method body must not have dependency to</param>
        /// <param name="moreTypes">More <see cref="Type" /> objects to which method body must not have dependency to</param>
        TRuleTypeConjunction DoNotHaveDependencyInMethodBodyTo(Type type, params Type[] moreTypes);

        /// <summary>
        ///     Select methods that have no dependency in method body to any element in <see cref="IObjectProvider{T}" />
        ///     <paramref name="types" /> for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveDependencyInMethodBodyTo(IObjectProvider{IType})" />
        /// </summary>
        /// <param name="types"><see cref="IType" /> to which method body must not have dependency to</param>
        TRuleTypeConjunction DoNotHaveDependencyInMethodBodyTo(IObjectProvider<IType> types);

        /// <summary>
        ///     Select methods that have no dependency in method body to any <see cref="IType" /> in <paramref name="types" /> for
        ///     further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveDependencyInMethodBodyTo(IEnumerable{IType})" />
        /// </summary>
        /// <param name="types"><see cref="IType" /> to which method body must not have dependency to</param>
        TRuleTypeConjunction DoNotHaveDependencyInMethodBodyTo(IEnumerable<IType> types);

        /// <summary>
        ///     Select methods that have no dependency in method body to any <see cref="Type" /> in <paramref name="types" /> for
        ///     further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveDependencyInMethodBodyTo(IEnumerable{Type})" />
        /// </summary>
        /// <param name="types"><see cref="Type" /> to which method body must not have dependency to</param>
        TRuleTypeConjunction DoNotHaveDependencyInMethodBodyTo(IEnumerable<Type> types);

        /// <summary>
        ///     Select methods that have no return type with full name containing <paramref name="pattern" /> for further analysis.
        ///     <para />
        ///     The <paramref name="pattern" /> must not match full name of return type if
        ///     <paramref name="useRegularExpressions" />=true.
        ///     <para />
        ///     Negation of <see cref="HaveReturnType(string,bool)" />
        /// </summary>
        /// <param name="pattern">A pattern to match full names of return types</param>
        /// <param name="useRegularExpressions">option if names have to match or contain <paramref name="pattern" /></param>
        TRuleTypeConjunction DoNotHaveReturnType(string pattern, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that have return type with full name not containing any string in <paramref name="patterns" /> for
        ///     further analysis.
        ///     <para />
        ///     No element in <paramref name="patterns" /> must match full name of return type if
        ///     <paramref name="useRegularExpressions" />=true.
        ///     <para />
        ///     Negation of <see cref="HaveReturnType(IEnumerable{string}, bool)" />
        /// </summary>
        /// <param name="patterns">Patterns to match full names of return types</param>
        /// <param name="useRegularExpressions">
        ///     option if names have to match or contain one element in
        ///     <paramref name="patterns" />
        /// </param>
        TRuleTypeConjunction DoNotHaveReturnType(IEnumerable<string> patterns, bool useRegularExpressions = false);

        /// <summary>
        ///     Select methods that have no return type <paramref name="firstType" /> or <paramref name="moreTypes" /> for further
        ///     analysis.
        ///     <para />
        ///     Negation of <see cref="HaveReturnType(IType, IType[])" />
        /// </summary>
        /// <param name="firstType"><see cref="IType" /> return type of methods</param>
        /// <param name="moreTypes">More <see cref="IType" /> return types of methods</param>
        TRuleTypeConjunction DoNotHaveReturnType(IType firstType, params IType[] moreTypes);

        /// <summary>
        ///     Select methods that have no return type in <paramref name="types" /> for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveReturnType(IEnumerable{IType})" />
        /// </summary>
        /// <param name="types"><see cref="IType" /> return types of methods</param>
        TRuleTypeConjunction DoNotHaveReturnType(IEnumerable<IType> types);

        /// <summary>
        ///     Select methods that return no element in <see cref="IObjectProvider{T}" /> <paramref name="types" /> for further
        ///     analysis.
        ///     <para />
        ///     Negation of <see cref="HaveReturnType(IObjectProvider{IType})" />
        /// </summary>
        /// <param name="types"><see cref="IObjectProvider{T}" /> of return types of methods</param>
        TRuleTypeConjunction DoNotHaveReturnType(IObjectProvider<IType> types);

        /// <summary>
        ///     Select methods that have no return type <paramref name="type" /> or <paramref name="moreTypes" /> for further
        ///     analysis.
        ///     <para />
        ///     Negation of <see cref="HaveReturnType(Type, Type[])" />
        /// </summary>
        /// <param name="type"><see cref="Type" /> return type of methods</param>
        /// <param name="moreTypes">More <see cref="Type" /> return types of methods</param>
        TRuleTypeConjunction DoNotHaveReturnType(Type type, params Type[] moreTypes);

        /// <summary>
        ///     Select methods that have no return type in <paramref name="types" /> for further analysis.
        ///     <para />
        ///     Negation of <see cref="HaveReturnType(IEnumerable{Type})" />
        /// </summary>
        /// <param name="types"><see cref="Type" /> return types of methods</param>
        TRuleTypeConjunction DoNotHaveReturnType(IEnumerable<Type> types);
    }
}