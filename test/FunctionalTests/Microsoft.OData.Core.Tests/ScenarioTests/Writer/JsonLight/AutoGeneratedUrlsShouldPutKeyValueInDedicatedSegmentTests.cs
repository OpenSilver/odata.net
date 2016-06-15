﻿//---------------------------------------------------------------------
// <copyright file="AutoGeneratedUrlsShouldPutKeyValueInDedicatedSegmentTests.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using System;
using System.IO;
using FluentAssertions;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using Xunit;

namespace Microsoft.OData.Tests.ScenarioTests.Writer.JsonLight
{
    public class AutoGeneratedUrlsShouldPutKeyValueInDedicatedSegmentTests
    {
        private EdmModel model;
        private IEdmEntitySet peopleSet;
        private EdmEntityType personType;
        private EdmEntityContainer entityContainer;

        public AutoGeneratedUrlsShouldPutKeyValueInDedicatedSegmentTests()
        {
            this.model = new EdmModel();
            this.entityContainer = new EdmEntityContainer("Namespace", "Container");

            this.personType = new EdmEntityType("Namespace", "Person");
            this.personType.AddKeys(this.personType.AddStructuralProperty("Key", EdmPrimitiveTypeKind.String));
            this.peopleSet = this.entityContainer.AddEntitySet("People", personType);
            model.AddElement(this.entityContainer);
            model.AddElement(this.personType);
        }

        [Fact]
        public void IfKeyAsSegmentSettingIsTrueAndNoModelIsGivenThenLinkShouldHaveKeyAsSegment()
        {
            this.SerializeEntryInFullMetadataJson(true, /*model*/ null)
                .Should().Contain("People/KeyValue")
                .And.NotContain("People('KeyValue')");
        }

        [Fact]
        public void IfKeyAsSegmentSettingIsTrueAndAModelIsGivenThenLinkShouldHaveKeyAsSegment()
        {
            this.SerializeEntryInFullMetadataJson(true, this.model, this.personType, this.peopleSet)
                .Should().Contain("People/KeyValue")
                .And.NotContain("People('KeyValue')");
        }

        [Fact]
        public void IfKeyAsSegmentSettingIsTrueAndModelHasKeyAsSegmentAnnotationThenLinkShouldHaveKeyAsSegment()
        {
            this.SetKeyAsSegmentAnnotationOnModel();
            this.SerializeEntryInFullMetadataJson(true, this.model, this.personType, this.peopleSet)
                .Should().Contain("People/KeyValue")
                .And.NotContain("People('KeyValue')");
        }

        [Fact]
        public void IfKeyAsSegmentSettingIsFalseAndNoModelIsGivenThenLinkShouldHaveKeyInParens()
        {
            this.SerializeEntryInFullMetadataJson(false, /*model*/ null)
                .Should().Contain("People('KeyValue')")
                .And.NotContain("People/KeyValue");
        }

        [Fact]
        public void IfKeyAsSegmentSettingIsFalseAndAModelIsGivenThenLinkShouldHaveKeyInParens()
        {
            this.SerializeEntryInFullMetadataJson(false, this.model, this.personType, this.peopleSet)
                .Should().Contain("People('KeyValue')")
                .And.NotContain("People/KeyValue");
        }

        [Fact]
        public void IfKeyAsSegmentSettingIsFalseAndModelHasKeyAsSegmentAnnotationThenLinkShouldNotHaveKeyAsSegment()
        {
            this.SetKeyAsSegmentAnnotationOnModel();
            this.SerializeEntryInFullMetadataJson(false, this.model, this.personType, this.peopleSet)
                .Should().Contain("People('KeyValue')")
                .And.NotContain("People/KeyValue");
        }


        [Fact]
        public void IfKeyAsSegmentSettingIsNullAndNoModelIsGivenThenLinkShouldHaveKeyInParens()
        {
            this.SerializeEntryInFullMetadataJson(null, /*model*/ null)
                .Should().Contain("People('KeyValue')")
                .And.NotContain("People/KeyValue");
        }

        [Fact]
        public void IfKeyAsSegmentSettingIsNullAndAModelIsGivenThenLinkShouldHaveKeyInParens()
        {
            this.SerializeEntryInFullMetadataJson(null, this.model, this.personType, this.peopleSet)
                .Should().Contain("People('KeyValue')")
                .And.NotContain("People/KeyValue");
        }

        [Fact]
        public void IfKeyAsSegmentSettingIsNullAndModelHasKeyAsSegmentAnnotationThenLinkShouldHaveKeyAsSegment()
        {
            this.SetKeyAsSegmentAnnotationOnModel();
            this.SerializeEntryInFullMetadataJson(null, this.model, this.personType, this.peopleSet)
                .Should().Contain("People/KeyValue")
                .And.NotContain("People('KeyValue')");
        }

        private void SetKeyAsSegmentAnnotationOnModel()
        {
            this.model.AddVocabularyAnnotation(
                new EdmAnnotation(
                    this.entityContainer,
                    new EdmTerm(
                        "Com.Microsoft.OData.Service.Conventions.V1", 
                        "UrlConventions", 
                        EdmPrimitiveTypeKind.String), 
                        new EdmStringConstant("KeyAsSegment")));
        }

        private string SerializeEntryInFullMetadataJson(
            bool? useKeyAsSegment, 
            IEdmModel edmModel, 
            IEdmEntityType entityType = null, 
            IEdmEntitySet entitySet = null)
        {
            var settings = new ODataMessageWriterSettings
            {
                AutoComputePayloadMetadata = true,
                UseKeyAsSegment = useKeyAsSegment,
            };

            settings.SetServiceDocumentUri(new Uri("http://example.com/"));

            var outputStream = new MemoryStream();
            var responseMessage = new InMemoryMessage {Stream = outputStream};
            responseMessage.SetHeader("Content-Type", "application/json;odata.metadata=full");
            string output;

            using(var messageWriter = new ODataMessageWriter((IODataResponseMessage)responseMessage, settings, edmModel))
            {
                var entryWriter = messageWriter.CreateODataResourceWriter(entitySet, entityType);
                ODataProperty keyProperty = new ODataProperty() {Name = "Key", Value = "KeyValue"};

                var entry = new ODataResource {Properties = new[] {keyProperty}, TypeName = "Namespace.Person"};

                if (edmModel == null)
                {
                    keyProperty.SetSerializationInfo(new ODataPropertySerializationInfo
                    {
                        PropertyKind = ODataPropertyKind.Key
                    });

                    entry.SetSerializationInfo(new ODataResourceSerializationInfo
                    {
                        NavigationSourceEntityTypeName = "Namespace.Person",
                        NavigationSourceName = "People",
                        ExpectedTypeName = "Namespace.Person"
                    });
                }

                entryWriter.WriteStart(entry);
                entryWriter.WriteEnd();
                entryWriter.Flush();

                outputStream.Seek(0, SeekOrigin.Begin);
                output = new StreamReader(outputStream).ReadToEnd();
            }

            return output;
        }
    }
}
