// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

using FluentAssertions;
using Steeltoe.InitializrApi.Models;
using Xunit;

namespace Steeltoe.InitializrApi.Test.Unit.Models
{
    public class ProjectSpecTests
    {
        /* ----------------------------------------------------------------- *
         * positive tests                                                    *
         * ----------------------------------------------------------------- */

        [Fact]
        public void Properties_Should_Be_Defined()
        {
            // Arrange
            var spec = new ProjectSpec();

            // Act

            // Assert
            spec.Name.Should().BeNull();
            spec.Description.Should().BeNull();
            spec.Namespace.Should().BeNull();
            spec.SteeltoeVersion.Should().Be("3.0.0");
            spec.DotNetFramework.Should().Be("netcoreapp3.1");
            spec.Language.Should().BeNull();
            spec.Packaging.Should().BeNull();
        }

        [Fact]
        public void Application_Should_Be_Default_to_Name()
        {
            // Arrange
            var spec = new ProjectSpec();

            // Act
            spec.Name = "foo";

            // Assert
            spec.Namespace.Should().Be("foo");

            // Act
            spec.Namespace = "bar";

            // Assert
            spec.Namespace.Should().Be("bar");
        }

        /* ----------------------------------------------------------------- *
         * negative tests                                                    *
         * ----------------------------------------------------------------- */
    }
}
