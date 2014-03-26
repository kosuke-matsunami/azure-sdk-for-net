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
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure
{
    /// <summary>
    /// The Service Management API provides programmatic access to much of the
    /// functionality available through the Management Portal. The Service
    /// Management API is a REST API. All API operations are performed over
    /// SSL, and are mutually authenticated using X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class VirtualMachineVMImageOperationsExtensions
    {
        /// <summary>
        /// The Begin Deleting Virtual Machine Image operation deletes the
        /// specified virtual machine image.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineVMImageOperations.
        /// </param>
        /// <param name='vmImageName'>
        /// Required. The name of the virtual machine image to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static OperationResponse BeginDeleting(this IVirtualMachineVMImageOperations operations, string vmImageName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineVMImageOperations)s).BeginDeletingAsync(vmImageName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Begin Deleting Virtual Machine Image operation deletes the
        /// specified virtual machine image.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineVMImageOperations.
        /// </param>
        /// <param name='vmImageName'>
        /// Required. The name of the virtual machine image to delete.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<OperationResponse> BeginDeletingAsync(this IVirtualMachineVMImageOperations operations, string vmImageName)
        {
            return operations.BeginDeletingAsync(vmImageName, CancellationToken.None);
        }
        
        /// <summary>
        /// The Delete Virtual Machine Image operation deletes the specified
        /// virtual machine image.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineVMImageOperations.
        /// </param>
        /// <param name='vmImageName'>
        /// Required. The name of the virtual machine image to delete.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static OperationStatusResponse Delete(this IVirtualMachineVMImageOperations operations, string vmImageName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineVMImageOperations)s).DeleteAsync(vmImageName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Delete Virtual Machine Image operation deletes the specified
        /// virtual machine image.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineVMImageOperations.
        /// </param>
        /// <param name='vmImageName'>
        /// Required. The name of the virtual machine image to delete.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself. If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request. If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request and error information regarding
        /// the failure.
        /// </returns>
        public static Task<OperationStatusResponse> DeleteAsync(this IVirtualMachineVMImageOperations operations, string vmImageName)
        {
            return operations.DeleteAsync(vmImageName, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Virtual Machine Images operation retrieves a list of the
        /// virtual machine images.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineVMImageOperations.
        /// </param>
        /// <returns>
        /// The List VM Images operation response.
        /// </returns>
        public static VirtualMachineVMImageListResponse List(this IVirtualMachineVMImageOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IVirtualMachineVMImageOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Virtual Machine Images operation retrieves a list of the
        /// virtual machine images.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.Compute.IVirtualMachineVMImageOperations.
        /// </param>
        /// <returns>
        /// The List VM Images operation response.
        /// </returns>
        public static Task<VirtualMachineVMImageListResponse> ListAsync(this IVirtualMachineVMImageOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}
