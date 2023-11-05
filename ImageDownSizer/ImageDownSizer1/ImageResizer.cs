using System;

namespace ImageDownSizer1
{
    public class ImageResizer
    {
        public static byte[,,] ResizeImage(byte[,,] originalImage, int originalWidth, int originalHeight, int newWidth, int newHeight)
        {
            byte[,,] resizedImage = new byte[newWidth, newHeight, 3];
            float xScale = originalWidth / (float)newWidth;
            float yScale = originalHeight / (float)newHeight;

            for (int x = 0; x < newWidth; x++)
            {
                for (int y = 0; y < newHeight; y++)
                {
                    float sourceX = x * xScale;
                    float sourceY = y * yScale;

                    for (int channel = 0; channel < 3; channel++)
                    {
                        resizedImage[x, y, channel] = GetInterpolatedPixel(originalImage, sourceX, sourceY, channel, originalWidth, originalHeight);
                    }
                }
            }

            return resizedImage;
        }

        private static byte GetInterpolatedPixel(byte[,,] image, float x, float y, int channel, int width, int height)
        {
            int x1 = (int)x;
            int y1 = (int)y;
            int x2 = Math.Min(x1 + 1, width - 1);
            int y2 = Math.Min(y1 + 1, height - 1);

            float dx = x - x1;
            float dy = y - y1;

            float topInterpolation = LinearInterpolate(image[x1, y1, channel], image[x2, y1, channel], dx);
            float bottomInterpolation = LinearInterpolate(image[x1, y2, channel], image[x2, y2, channel], dx);

            return (byte)LinearInterpolate(topInterpolation, bottomInterpolation, dy);
        }

        private static float LinearInterpolate(float a, float b, float t)
        {
            return a * (1 - t) + b * t;
        }
    }
}
