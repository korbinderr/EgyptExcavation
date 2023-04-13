using Microsoft.ML.OnnxRuntime.Tensors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intex00.Models
{
    public class WrappingData
    {
        public float squarenorthsouth { get; set; }
        public float depth { get; set; }
        public float squareeastwest { get; set; }
        public float westtohead { get; set; }
        public float westtofeet { get; set; }
        public float southtofeet { get; set; }
        public float fieldbookexcavationyear { get; set; }
        public float eastwest_E { get; set; }
        public float eastwest_W { get; set; }
        public float adultsubadult_A { get; set; }
        public float adultsubadult_C { get; set; }
        public float samplescollected_false { get; set; }
        public float samplescollected_true { get; set; }
        public float samplescollected_unknown { get; set; }
        public float area_NE { get; set; }
        public float area_NNW { get; set; }
        public float area_NW { get; set; }
        public float area_SE { get; set; }
        public float area_SW { get; set; }
        public float consts { get; set; }

        public Tensor<float> AssTensor()
        {
            float[] data = new float[]
            {
            squarenorthsouth, depth, squareeastwest, westtohead,westtofeet,southtofeet,fieldbookexcavationyear,eastwest_E,eastwest_W,adultsubadult_A,adultsubadult_C,samplescollected_false,samplescollected_true,samplescollected_unknown,area_NE,area_NNW,area_NW,area_SE,area_SW,consts
            };
            int[] dimensions = new int[] { 1, 20 };
            return new DenseTensor<float>(data, dimensions);
        }
    }
}
