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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// The List Operating Systems operation response.
    /// </summary>
    public partial class OperatingSystemListResponse : OperationResponse, IEnumerable<OperatingSystemListResponse.OperatingSystem>
    {
        private IList<OperatingSystemListResponse.OperatingSystem> _operatingSystems;
        
        /// <summary>
        /// Optional. The operating systems that are valid for your
        /// subscription.
        /// </summary>
        public IList<OperatingSystemListResponse.OperatingSystem> OperatingSystems
        {
            get { return this._operatingSystems; }
            set { this._operatingSystems = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the OperatingSystemListResponse class.
        /// </summary>
        public OperatingSystemListResponse()
        {
            this._operatingSystems = new List<OperatingSystemListResponse.OperatingSystem>();
        }
        
        /// <summary>
        /// Gets the sequence of OperatingSystems.
        /// </summary>
        public IEnumerator<OperatingSystemListResponse.OperatingSystem> GetEnumerator()
        {
            return this.OperatingSystems.GetEnumerator();
        }
        
        /// <summary>
        /// Gets the sequence of OperatingSystems.
        /// </summary>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        /// <summary>
        /// An operating system that is valid for your subscription.
        /// </summary>
        public partial class OperatingSystem
        {
            private int _family;
            
            /// <summary>
            /// Optional. Indicates which operating system family this version
            /// belongs to. A value of 1 corresponds to the Azure guest
            /// operating system that is substantially compatible with Windows
            /// Server 2008 SP2. A value of 2 corresponds to the Azure guest
            /// operating system that is substantially compatible with Windows
            /// Server 2008 R2.
            /// </summary>
            public int Family
            {
                get { return this._family; }
                set { this._family = value; }
            }
            
            private string _familyLabel;
            
            /// <summary>
            /// Optional. The label of the operating system family.
            /// </summary>
            public string FamilyLabel
            {
                get { return this._familyLabel; }
                set { this._familyLabel = value; }
            }
            
            private bool _isActive;
            
            /// <summary>
            /// Optional. Indicates whether this operating system version is
            /// currently active for running a service. If an operating system
            /// version is active, you can manually configure your service to
            /// run on that version. An operating system version may be
            /// inactive for one of two reasons: 1. It is not yet active as it
            /// is in the process of being rolled out to Azure data centers.
            /// If your service is configured to use auto-upgrade, it will be
            /// upgraded to the new operating system version during the
            /// rollout. If you are manually configuring your operating system
            /// version, you can upgrade to the latest version once it becomes
            /// active. 2. It is no longer supported for running a service. In
            /// this case you will either need to manually configure your
            /// service to run on a newer version, or configure your service
            /// to use auto-upgrade to manage operating system upgrades.
            /// </summary>
            public bool IsActive
            {
                get { return this._isActive; }
                set { this._isActive = value; }
            }
            
            private bool _isDefault;
            
            /// <summary>
            /// Optional. Indicates whether this operating system version is
            /// the default version for a service that has not otherwise
            /// specified a particular version. The default operating system
            /// version is applied to services that are configured for
            /// auto-upgrade. An operating system family has exactly one
            /// default operating system version at any given time, for which
            /// the IsDefault element is set to true; for all other versions,
            /// IsDefault is set to false.
            /// </summary>
            public bool IsDefault
            {
                get { return this._isDefault; }
                set { this._isDefault = value; }
            }
            
            private string _label;
            
            /// <summary>
            /// Optional. The label of the operating system version.
            /// </summary>
            public string Label
            {
                get { return this._label; }
                set { this._label = value; }
            }
            
            private string _version;
            
            /// <summary>
            /// Optional. The operating system version. This value corresponds
            /// to the configuration value for specifying that your service is
            /// to run on a particular version of the Azure guest operating
            /// system. See Configuring Settings for the Windows Azure Guest
            /// OS for additional details.
            /// </summary>
            public string Version
            {
                get { return this._version; }
                set { this._version = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the OperatingSystem class.
            /// </summary>
            public OperatingSystem()
            {
            }
        }
    }
}
