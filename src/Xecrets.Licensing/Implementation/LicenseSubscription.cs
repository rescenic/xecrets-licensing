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

namespace Xecrets.Licensing.Implementation
{
    /// <summary>
    /// The subscription, with an expiration, a licensee and valid for a product
    /// </summary>
    public class LicenseSubscription
    {
        /// <summary>
        /// An empty default subscription
        /// </summary>
        public static readonly LicenseSubscription Empty = new LicenseSubscription(DateTime.MinValue, string.Empty, string.Empty);

        /// <summary>
        /// Instantiate a subscription
        /// </summary>
        /// <param name="expirationUtc">The date and time of expiration.</param>
        /// <param name="licensee">The licensee, an arbitrary string representing the holder of the license.</param>
        /// <param name="product">The product that is licensed, an arbitrary string.</param>
        public LicenseSubscription(DateTime expirationUtc, string licensee, string product)
        {
            ExpirationUtc = expirationUtc;
            Licensee = licensee;
            Product = product;
        }

        /// <summary>
        /// The date and time of expiration.
        /// </summary>
        public DateTime ExpirationUtc { get; }

        /// <summary>
        /// The licensee, an arbitrary string representing the holder of the license.
        /// </summary>
        public string Licensee { get; }

        /// <summary>
        /// The product that is licensed, an arbitrary string.
        /// </summary>
        public string Product { get; }
    }
}
