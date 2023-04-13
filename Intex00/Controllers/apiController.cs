//using Intex00.Models;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.ML.OnnxRuntime;
//using Microsoft.ML.OnnxRuntime.Tensors;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Intex00.Controllers
//{
//    [ApiController]
//    [Route("/predict")]
//    public class apiController : Controller
//    {
//        private InferenceSession _session;

//        public apiController(InferenceSession session)
//        {
//            _session = session;
//        }

//        [HttpPost]
//        public ActionResult Score(WrappingData data)
//        {
//            var result = _session.Run(new List<NamedOnnxValue>
//            {
//                NamedOnnxValue.CreateFromTensor("float_input", data.AssTensor())
//            });
//            Tensor<string> score = result.First().AsTensor<string>();
//            var prediction = new predictions { PredictedValue = score.First() };
//            result.Dispose();
//            return Ok(prediction);
//        }
//    }
//}
