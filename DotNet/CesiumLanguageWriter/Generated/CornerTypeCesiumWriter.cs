﻿// <auto-generated>
// This file was generated automatically by GenerateFromSchema. Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using JetBrains.Annotations;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>CornerType</c> to a <see cref="CesiumOutputStream"/>. A <c>CornerType</c> is the style of a corner.
    /// </summary>
    public class CornerTypeCesiumWriter : CesiumPropertyWriter<CornerTypeCesiumWriter>, ICesiumDeletablePropertyWriter, ICesiumCornerTypeValuePropertyWriter, ICesiumReferenceValuePropertyWriter
    {
        /// <summary>
        /// The name of the <c>cornerType</c> property.
        /// </summary>
        public const string CornerTypePropertyName = "cornerType";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        /// <summary>
        /// The name of the <c>delete</c> property.
        /// </summary>
        public const string DeletePropertyName = "delete";

        private readonly Lazy<CesiumCornerTypeValuePropertyAdaptor<CornerTypeCesiumWriter>> m_asCornerType;
        private readonly Lazy<CesiumReferenceValuePropertyAdaptor<CornerTypeCesiumWriter>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        /// <param name="propertyName">The name of the property.</param>
        public CornerTypeCesiumWriter([NotNull] string propertyName)
            : base(propertyName)
        {
            m_asCornerType = CreateAsCornerType();
            m_asReference = CreateAsReference();
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected CornerTypeCesiumWriter([NotNull] CornerTypeCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asCornerType = CreateAsCornerType();
            m_asReference = CreateAsReference();
        }

        /// <inheritdoc/>
        public override CornerTypeCesiumWriter Clone()
        {
            return new CornerTypeCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cornerType</c>, which is the corner style.
        /// </summary>
        /// <param name="value">The style of a corner.</param>
        public void WriteCornerType(CesiumCornerType value)
        {
            const string PropertyName = CornerTypePropertyName;
            if (ForceInterval)
            {
                OpenIntervalIfNecessary();
            }
            if (IsInterval)
            {
                Output.WritePropertyName(PropertyName);
            }
            Output.WriteValue(CesiumFormattingHelper.CornerTypeToString(value));
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the corner style specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the corner style specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the corner style specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the corner style specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Writes the value expressed as a <c>delete</c>, which is whether the client should delete existing samples or interval data for this property. Data will be deleted for the containing interval, or if there is no containing interval, then all data. If true, all other properties in this property will be ignored.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDelete(bool value)
        {
            const string PropertyName = DeletePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(value);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumCornerTypeValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumCornerTypeValuePropertyAdaptor<CornerTypeCesiumWriter> AsCornerType()
        {
            return m_asCornerType.Value;
        }

        private Lazy<CesiumCornerTypeValuePropertyAdaptor<CornerTypeCesiumWriter>> CreateAsCornerType()
        {
            return new Lazy<CesiumCornerTypeValuePropertyAdaptor<CornerTypeCesiumWriter>>(CreateCornerType, false);
        }

        private CesiumCornerTypeValuePropertyAdaptor<CornerTypeCesiumWriter> CreateCornerType()
        {
            return CesiumValuePropertyAdaptors.CreateCornerType(this);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumReferenceValuePropertyWriter"/>. Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close"/> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public CesiumReferenceValuePropertyAdaptor<CornerTypeCesiumWriter> AsReference()
        {
            return m_asReference.Value;
        }

        private Lazy<CesiumReferenceValuePropertyAdaptor<CornerTypeCesiumWriter>> CreateAsReference()
        {
            return new Lazy<CesiumReferenceValuePropertyAdaptor<CornerTypeCesiumWriter>>(CreateReference, false);
        }

        private CesiumReferenceValuePropertyAdaptor<CornerTypeCesiumWriter> CreateReference()
        {
            return CesiumValuePropertyAdaptors.CreateReference(this);
        }

    }
}
