
namespace HackerRank.Easy
{
    public class HalloweenPartySolution
    {
        public string[] Outputs { get; private set; }

        public HalloweenPartySolution(string[] inputs)
        {
            Outputs = new string[inputs.Length];

            for (int i = 0; i < inputs.Length; i++)
            {
                int k = int.Parse(inputs[i]);
                Outputs[i] = DeterminePieces(k).ToString();
            }
        }

        private static long DeterminePieces(int slices)
        {
            int horizontal = slices / 2;
            int remainder = slices % 2;

            return (long)horizontal * (horizontal + remainder);
        }
    }

}
