﻿/*
 * Copyright 2019 TNG Technology Consulting GmbH
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.Collections.Generic;
using ArchUnitNET.Core;
using ArchUnitNET.Domain.Dependencies.Types;

namespace ArchUnitNET.Domain
{
    public class Interface : IType
    {
        private readonly Type _type;

        public Interface(Type type)
        {
            _type = type;
        }

        public string Name => _type.Name;
        public string FullName => _type.FullName;

        public Namespace Namespace => _type.Namespace;
        public Assembly Assembly => _type.Assembly;

        public List<Attribute> Attributes { get; } = new List<Attribute>();

        public List<ITypeDependency> Dependencies => _type.Dependencies;
        public List<ITypeDependency> BackwardsDependencies => _type.BackwardsDependencies;
        public IEnumerable<IType> ImplementedInterfaces => _type.ImplementedInterfaces;

        public MemberList Members => _type.Members;
        public List<IType> GenericTypeParameters => _type.GenericTypeParameters;
        public IType GenericType => _type.GenericType;
        public List<IType> GenericTypeArguments => _type.GenericTypeArguments;

        public bool Implements(IType intf)
        {
            return _type.Implements(intf);
        }

        public bool IsAssignableTo(IType assignableToType)
        {
            if (assignableToType is Interface @interface)
                
            {
                return Implements(@interface);
            }

            return false;
        }

        private bool Equals(Interface other)
        {
            return Equals(_type, other._type);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return obj.GetType() == GetType() && Equals((Interface) obj);
        }

        public override int GetHashCode()
        {
            return _type != null ? _type.GetHashCode() : 0;
        }
    }
}