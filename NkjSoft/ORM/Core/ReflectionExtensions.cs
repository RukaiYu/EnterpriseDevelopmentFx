﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// This source code is made available under the terms of the Microsoft Public License (MS-PL)

using System;
using System.Reflection;

namespace NkjSoft.ORM.Core
{
    /// <summary>
    /// 
    /// </summary>
    public static class ReflectionExtensions
    {
        /// <summary>
        /// 获取当前实体实例成员的指定字段、属性的值。
        /// </summary>
        /// <param name="member">The member.</param>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static object GetValue(this MemberInfo member, object instance)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Property:
                    return ((PropertyInfo)member).GetValue(instance, null);
                case MemberTypes.Field:
                    return ((FieldInfo)member).GetValue(instance);
                default:
                    throw new InvalidOperationException();
            }
        }

        /// <summary>
        /// Sets the value.
        /// </summary>
        /// <param name="member">The member.</param>
        /// <param name="instance">The instance.</param>
        /// <param name="value">The value.</param>
        public static void SetValue(this MemberInfo member, object instance, object value)
        {
            switch (member.MemberType)
            {
                case MemberTypes.Property:
                    var pi = (PropertyInfo)member;
                    //TODO:提高效率??
                    // Common.DataUtils.SetPropertyValue(instance, pi, value);
                    pi.SetValue(instance, value, null);
                    break;
                case MemberTypes.Field:
                    var fi = (FieldInfo)member;
                    fi.SetValue(instance, value);
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}