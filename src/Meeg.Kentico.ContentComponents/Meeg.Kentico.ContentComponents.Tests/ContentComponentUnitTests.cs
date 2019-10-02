﻿using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.KenticoContrib;
using CMS.Tests;
using NUnit.Framework;
using Tests.DocumentEngine;

namespace Meeg.Kentico.ContentComponents.Tests
{
    public class ContentComponentUnitTests : UnitTests
    {
        [SetUp]
        public void RegisterPageTypes()
        {
            DocumentGenerator.RegisterDocumentType<PageMetadata>(PageMetadata.CLASS_NAME);
            Fake().DocumentType<PageMetadata>(PageMetadata.CLASS_NAME);

            DocumentGenerator.RegisterDocumentType<OpenGraphMetadata>(OpenGraphMetadata.CLASS_NAME);
            Fake().DocumentType<OpenGraphMetadata>(OpenGraphMetadata.CLASS_NAME);

            DocumentGenerator.RegisterDocumentType<Page>(Page.CLASS_NAME);
            Fake().DocumentType<Page>(Page.CLASS_NAME);
        }
    }
}
