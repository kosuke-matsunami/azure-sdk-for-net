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
using System.Linq;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// Specifies a public key in the SSH settings.
    /// </summary>
    public partial class SshSettingPublicKey
    {
        private string _fingerprint;
        
        /// <summary>
        /// Required. Specifies the SHA1 fingerprint of an X509 certificate
        /// associated with the hosted service that includes the SSH public
        /// key.
        /// </summary>
        public string Fingerprint
        {
            get { return this._fingerprint; }
            set { this._fingerprint = value; }
        }
        
        private string _path;
        
        /// <summary>
        /// Required. Specifies the full path of a file on the virtual machine
        /// which stores the SSH public key. If the file already exists, the
        /// specified key is appended to the file. Example:
        /// /home/user/.ssh/authorized_keys.
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the SshSettingPublicKey class.
        /// </summary>
        public SshSettingPublicKey()
        {
        }
    }
}
