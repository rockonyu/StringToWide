
namespace StringToWide {
    public class Transform {
        public string TextTransform(string input, bool isWide, bool isSimplified) {
            var result = input;
            result = isWide ? result.ToWide() : result.ToNarrow();
            result = isSimplified ? result.ToSimplified() : result.ToTraditional();
            return result;
        }
    }
}
