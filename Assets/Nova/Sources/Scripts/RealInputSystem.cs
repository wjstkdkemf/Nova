﻿using UnityEngine;
using UnityEngine.EventSystems;

namespace Nova
{
    public class RealInputSystem : BaseInput
    {
        public BaseInput originalInput;

        public override Vector2 mousePosition => originalInput.mousePosition - RealScreen.offset;

        public override Touch GetTouch(int index)
        {
            var touch = base.GetTouch(index);
            touch.position -= RealScreen.offset;
            return touch;
        }
    }

    public static class RealInput
    {
        // TODO: may not be needed in newer unity engine
        public static Vector3 mousePosition => Input.mousePosition - (Vector3)RealScreen.offset;
    }
}