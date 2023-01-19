using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatGPT
{
    [Headers("Authorization: Bearer")]
    public interface ICompletionsAPI
    {
        [Post("/v1/completions")]
        Task<CompletionResponse> CreateCompletion(CompletionRequest request);
    }
}
