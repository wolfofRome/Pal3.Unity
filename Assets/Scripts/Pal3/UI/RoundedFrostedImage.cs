// ---------------------------------------------------------------------------------------------
//  Copyright (c) 2021-2022, Jiaqi Liu. All rights reserved.
//  See LICENSE file in the project root for license information.
// ---------------------------------------------------------------------------------------------

namespace Pal3.UI
{
    using UnityEngine;
    using UnityEngine.UI;

    [RequireComponent(typeof(RectTransform))]
    public class RoundedFrostedImage : MonoBehaviour
    {
        private static readonly int BlurAmountPropertyId = Shader.PropertyToID("_BlurAmount");
        private static readonly int WidthHeightRadiusPropertyId = Shader.PropertyToID("_WidthHeightRadius");
        private static readonly int AdditiveColorPropertyId = Shader.PropertyToID("_AdditiveColor");
        private static readonly int MultiplyColorPropertyId = Shader.PropertyToID("_MultiplyColor");

        [SerializeField] public float blurAmount = 1;
        [SerializeField] public float cornerRadius;
        [SerializeField] public Color additiveTintColor = Color.black;
        [SerializeField] public Color multiplyTintColor = Color.white;

        private Material _material;

        [HideInInspector, SerializeField] private MaskableGraphic image;

        private void OnValidate()
        {
            Validate();
            Refresh();
        }

        private void OnDestroy()
        {
            Destroy(_material);
            image = null;
            _material = null;
        }

        private void OnEnable()
        {
            Validate();
            Refresh();
        }

        private void OnRectTransformDimensionsChange()
        {
            if (enabled && _material != null)
            {
                Refresh();
            }
        }

        private void Validate()
        {
            if (_material == null)
            {
                _material = new Material(Shader.Find("Pal3/RoundedFrostedGlass"));
            }

            if (image == null)
            {
                TryGetComponent(out image);
            }

            if (image != null)
            {
                image.material = _material;
            }
        }

        private void Refresh()
        {
            var rect = ((RectTransform)transform).rect;

            _material.SetFloat(BlurAmountPropertyId, blurAmount);
            _material.SetColor(AdditiveColorPropertyId, additiveTintColor);
            _material.SetColor(MultiplyColorPropertyId, multiplyTintColor);
            _material.SetVector(WidthHeightRadiusPropertyId,
                new Vector4(rect.width, rect.height, cornerRadius, 0));
        }
    }
}