﻿#region Coypright and License

/*
 * Xecrets Licensing - Copyright © 2022-2023, Svante Seleborg, All Rights Reserved.
 *
 * This code file is part of Xecrets Licensing
 * 
 * Unless explicitly licensed in writing, this source code is the sole property of Axantum Software AB,
 * and may not be copied, distributed, sold, modified or otherwise used in any way.
*/

#endregion Coypright and License

using System.Globalization;

using Xecrets.Licensing.Abstractions;

namespace Xecrets.Licensing.Implementation
{
    /// <summary>
    /// An <see cref="ILicenseExpiration"/> implementation comparing the license with date and time of the build.
    /// </summary>
    public class LicenseExpirationByBuildTime : ILicenseExpiration
    {
        private readonly INewLocator _newLocator;

        /// <summary>
        /// Instantiate an instance providing a locator
        /// </summary>
        /// <param name="newLocator">The <see cref="INewLocator"/> to use to get dependencies.</param>
        public LicenseExpirationByBuildTime(INewLocator newLocator)
        {
            _newLocator = newLocator;
        }

        /// <inheritdoc/>
        public bool IsExpired(DateTime expiresUtc)
        {
                string buildUtcText = _newLocator.New<IBuildUtc>().BuildUtcText;
                DateTime buildUtc = DateTime.Parse(buildUtcText, CultureInfo.GetCultureInfo("en-US")).ToUniversalTime();
                return expiresUtc < buildUtc;
        }
    }
}