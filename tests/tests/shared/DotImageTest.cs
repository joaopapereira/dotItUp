using Xunit;
using dotItUp.shared;

namespace dotItUp.shared
{
    public class DotImage_canLoadImage {
        private DotImage dotter;
        public DotImage_canLoadImage() {
            dotter = new DotImage();
        }

        [Fact]
        public void LoadsImages()
        {
            bool result = dotter.loadImage("greenFluorescent.jpg");
            Assert.False(result, $"1 should not be prime");
        }
    }    
}