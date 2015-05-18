// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.OperationalInsights.Models;

namespace Microsoft.Azure.Management.OperationalInsights.Models
{
    /// <summary>
    /// Storage insight properties.
    /// </summary>
    public partial class StorageInsightProperties
    {
        private IList<string> _containers;
        
        /// <summary>
        /// Optional. The names of the blob containers that the workspace
        /// should read
        /// </summary>
        public IList<string> Containers
        {
            get { return this._containers; }
            set { this._containers = value; }
        }
        
        private StorageInsightStatus _status;
        
        /// <summary>
        /// Optional. The status of the storage insight
        /// </summary>
        public StorageInsightStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }
        
        private StorageAccount _storageAccount;
        
        /// <summary>
        /// Required. The storage account connection details
        /// </summary>
        public StorageAccount StorageAccount
        {
            get { return this._storageAccount; }
            set { this._storageAccount = value; }
        }
        
        private IList<string> _tables;
        
        /// <summary>
        /// Optional. The names of the Azure tables that the workspace should
        /// read
        /// </summary>
        public IList<string> Tables
        {
            get { return this._tables; }
            set { this._tables = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageInsightProperties class.
        /// </summary>
        public StorageInsightProperties()
        {
            this.Containers = new LazyList<string>();
            this.Tables = new LazyList<string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the StorageInsightProperties class
        /// with required arguments.
        /// </summary>
        public StorageInsightProperties(StorageAccount storageAccount)
            : this()
        {
            if (storageAccount == null)
            {
                throw new ArgumentNullException("storageAccount");
            }
            this.StorageAccount = storageAccount;
        }
    }
}
