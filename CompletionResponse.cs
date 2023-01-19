using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChatGPT
{
    public class CompletionResponse
    {
        public IEnumerable<ChoiceCompletionResponse> Choices { get; set;} = new List<ChoiceCompletionResponse>();
    }
}
