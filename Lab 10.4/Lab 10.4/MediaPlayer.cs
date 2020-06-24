using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10._4
{
    class MediaPlayer
    {
        public void PlayMedia (IAudioPlayer media)
        {
            media.Play();
        }
    }
}
