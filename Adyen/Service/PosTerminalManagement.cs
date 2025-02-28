﻿#region Licence

// 
//                        ######
//                        ######
//  ############    ####( ######  #####. ######  ############   ############
//  #############  #####( ######  #####. ######  #############  #############
//         ######  #####( ######  #####. ######  #####  ######  #####  ######
//  ###### ######  #####( ######  #####. ######  #####  #####   #####  ######
//  ###### ######  #####( ######  #####. ######  #####          #####  ######
//  #############  #############  #############  #############  #####  ######
//   ############   ############  #############   ############  #####  ######
//                                       ######
//                                #############
//                                ############
// 
//  Adyen Dotnet API Library
// 
//  Copyright (c) 2020 Adyen B.V.
//  This file is open source and available under the MIT license.
//  See the LICENSE file for more info.

#endregion

using System.Threading.Tasks;
using Adyen.Model.PosTerminalManagement;
using Adyen.Service.Resource.PosTerminalManagement;
using Newtonsoft.Json;

namespace Adyen.Service
{
    public class PosTerminalManagement : AbstractService
    {
        private readonly AssignTerminals _assignTerminals;
        private readonly FindTerminal _findTerminal;
        private readonly GetTerminalsUnderAccount _getTerminalsUnderAccount;
        private readonly GetTerminalDetails _getTerminalDetails;
        private readonly GetStoresUnderAccount _getStoresUnderAccount;

        public PosTerminalManagement(Client client) : base(client)
        {
            _assignTerminals = new AssignTerminals(this);
            _findTerminal = new FindTerminal(this);
            _getTerminalsUnderAccount = new GetTerminalsUnderAccount(this);
            _getTerminalDetails = new GetTerminalDetails(this);
            _getStoresUnderAccount = new GetStoresUnderAccount(this);
        }
        /// <summary>
        /// post /assingTerminals
        /// </summary>
        /// <param name="assignTerminalsRequest"></param>
        /// <returns>AssignTerminalsResponse</returns>
        public AssignTerminalsResponse AssignTerminals(AssignTerminalsRequest assignTerminalsRequest)
        {
            var jsonRequest = assignTerminalsRequest.ToJson();
            var jsonResponse = _assignTerminals.Request(jsonRequest);
            return JsonConvert.DeserializeObject<AssignTerminalsResponse>(jsonResponse);
        }
        /// <summary>
        /// post /assingTerminals
        /// </summary>
        /// <param name="assignTerminalsRequest"></param>
        /// <returns>task AssignTerminalsResponse</returns>
        public async Task<AssignTerminalsResponse> AssignTerminalsAsync(AssignTerminalsRequest assignTerminalsRequest)
        {
            var jsonRequest = assignTerminalsRequest.ToJson();
            var jsonResponse = await _assignTerminals.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<AssignTerminalsResponse>(jsonResponse);
        }
        /// <summary>
        /// post /findTerminal
        /// </summary>
        /// <param name="findTerminalRequest"></param>
        /// <returns>FindTerminalResponse</returns>
        public FindTerminalResponse FindTerminal(FindTerminalRequest findTerminalRequest)
        {
            var jsonRequest = findTerminalRequest.ToJson();
            var jsonResponse = _findTerminal.Request(jsonRequest);
            return JsonConvert.DeserializeObject<FindTerminalResponse>(jsonResponse);
        }
        /// <summary>
        /// post /findTerminal
        /// </summary>
        /// <param name="findTerminalRequest"></param>
        /// <returns>task FindTerminalResponse</returns>
        public async Task<FindTerminalResponse> FindTerminalAsync(FindTerminalRequest findTerminalRequest)
        {
            var jsonRequest = findTerminalRequest.ToJson();
            var jsonResponse = await _findTerminal.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<FindTerminalResponse>(jsonResponse);
        }
        /// <summary>
        /// post /getTerminalsUnderAccount
        /// </summary>
        /// <param name="getTerminalsUnderAccountRequest"></param>
        /// <returns>GetTerminalsUnderAccountResponse</returns>
        public GetTerminalsUnderAccountResponse GetTerminalsUnderAccount(GetTerminalsUnderAccountRequest getTerminalsUnderAccountRequest)
        {
            var jsonRequest = getTerminalsUnderAccountRequest.ToJson();
            var jsonResponse = _getTerminalsUnderAccount.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GetTerminalsUnderAccountResponse>(jsonResponse);
        }
        /// <summary>
        /// post /getTerminalsUnderAccount
        /// </summary>
        /// <param name="getTerminalsUnderAccountRequest"></param>
        /// <returns>task GetTerminalsUnderAccountResponse</returns>
        public async Task<GetTerminalsUnderAccountResponse> GetTerminalsUnderAccountAsync(GetTerminalsUnderAccountRequest getTerminalsUnderAccountRequest)
        {
            var jsonRequest = getTerminalsUnderAccountRequest.ToJson();
            var jsonResponse = await _getTerminalsUnderAccount.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GetTerminalsUnderAccountResponse>(jsonResponse);
        }

        /// <summary>
        /// post /getTerminalDetails
        /// </summary>
        /// <param name="getTerminalDetailsRequest"></param>
        /// <returns>GetTerminalDetailsResponse</returns>
        public GetTerminalDetailsResponse GetTerminalDetails(GetTerminalDetailsRequest getTerminalDetailsRequest)
        {
            var jsonRequest = getTerminalDetailsRequest.ToJson();
            var jsonResponse = _getTerminalDetails.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GetTerminalDetailsResponse>(jsonResponse);
        }

        /// <summary>
        /// post /getTerminalDetails
        /// </summary>
        /// <param name="getTerminalDetailsRequest"></param>
        /// <returns>task GetTerminalDetailsResponse</returns>
        public async Task<GetTerminalDetailsResponse> GetTerminalDetailsAsync(GetTerminalDetailsRequest getTerminalDetailsRequest)
        {
            var jsonRequest = getTerminalDetailsRequest.ToJson();
            var jsonResponse = await _getTerminalDetails.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GetTerminalDetailsResponse>(jsonResponse);
        }
        
        /// <summary>
        /// post /getStoresUnderAccount
        /// </summary>
        /// <param name="getStoresUnderAccountRequest"></param>
        /// <returns>GetStoresUnderAccountResponse</returns>
        public GetStoresUnderAccountResponse GetStoresUnderAccount(GetStoresUnderAccountRequest getStoresUnderAccountRequest)
        {
            var jsonRequest = getStoresUnderAccountRequest.ToJson();
            var jsonResponse =  _getStoresUnderAccount.Request(jsonRequest);
            return JsonConvert.DeserializeObject<GetStoresUnderAccountResponse>(jsonResponse);
        }
        
        /// <summary>
        /// post /getStoresUnderAccount
        /// </summary>
        /// <param name="getStoresUnderAccountRequest"></param>
        /// <returns>task GetStoresUnderAccountResponse</returns>
        public async Task<GetStoresUnderAccountResponse> GetStoresUnderAccountAsync(GetStoresUnderAccountRequest getStoresUnderAccountRequest)
        {
            var jsonRequest = getStoresUnderAccountRequest.ToJson();
            var jsonResponse = await _getStoresUnderAccount.RequestAsync(jsonRequest);
            return JsonConvert.DeserializeObject<GetStoresUnderAccountResponse>(jsonResponse);
        }
    }
}