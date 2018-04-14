﻿/***************************************************************
 * Description: 
 *
 * Documents: https://github.com/hiramtan/HiSocket_unity
 * Author: hiramtan@live.com
***************************************************************/

namespace HiSocket
{
    /// <summary>
    /// Tick interface
    /// </summary>
    public interface ITick
    {
        /// <summary>
        /// Tick 
        /// </summary>
        /// <param name="time">how many time passed with last tick</param>
        void Tick(float time);
    }
}