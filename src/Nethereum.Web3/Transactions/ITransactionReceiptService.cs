﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Nethereum.RPC.Eth.DTOs;

namespace Nethereum.Web3.Transactions
{
    public interface ITransactionReceiptService
    {
        Task<TransactionReceipt> SendRequestAsync(Func<Task<string>> transactionFunction,
            CancellationTokenSource tokenSource = null);

        Task<TransactionReceipt> DeployContractAsync(Func<Task<string>> deployFunction,
            CancellationTokenSource tokenSource = null);

        Task<string> DeployContractAndGetAddressAsync(Func<Task<string>> deployFunction,
            CancellationTokenSource tokenSource = null);

        Task<TransactionReceipt> SendRequestAsync(TransactionInput transactionInput,
            CancellationTokenSource tokenSource = null);

        Task<List<TransactionReceipt>> SendRequestAsync(IEnumerable<TransactionInput> transactionInputs,
            CancellationTokenSource tokenSource = null);
    }
}