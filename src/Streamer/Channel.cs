﻿using System.IO;

namespace Streamer
{
    public class Channel
    {
        public static ClientChannel CreateClient(Stream stream)
        {
            return new ClientChannel(stream);
        }

        public static ServerChannel CreateServer()
        {
            return new ServerChannel();
        }
    }
}
