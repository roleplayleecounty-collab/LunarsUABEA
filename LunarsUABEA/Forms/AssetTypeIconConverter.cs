using AssetsTools.NET.Extra;
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using HarfBuzzSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunarsUABEA
{
    public class AssetTypeIconConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is AssetClassID assetClass)
            {
                if ((int)assetClass < 0)
                {
                    return GetBitmap("LunarsUABEA/Assets/Icons/asset-mono-behaviour.png");
                }

                return assetClass switch
                {
                    AssetClassID.Animation => GetBitmap("LunarsUABEA/Assets/Icons/asset-animation.png"),
                    AssetClassID.AnimationClip => GetBitmap("LunarsUABEA/Assets/Icons/asset-animation-clip.png"),
                    AssetClassID.Animator => GetBitmap("LunarsUABEA/Assets/Icons/asset-animator.png"),
                    AssetClassID.AnimatorController => GetBitmap("LunarsUABEA/Assets/Icons/asset-animator-controller.png"),
                    AssetClassID.AnimatorOverrideController => GetBitmap("LunarsUABEA/Assets/Icons/asset-animator-override-controller.png"),
                    AssetClassID.AudioClip => GetBitmap("LunarsUABEA/Assets/Icons/asset-audio-clip.png"),
                    AssetClassID.AudioListener => GetBitmap("LunarsUABEA/Assets/Icons/asset-audio-listener.png"),
                    AssetClassID.AudioMixer => GetBitmap("LunarsUABEA/Assets/Icons/asset-audio-mixer.png"),
                    AssetClassID.AudioMixerGroup => GetBitmap("LunarsUABEA/Assets/Icons/asset-audio-mixer-group.png"),
                    AssetClassID.AudioSource => GetBitmap("LunarsUABEA/Assets/Icons/asset-audio-source.png"),
                    AssetClassID.Avatar => GetBitmap("LunarsUABEA/Assets/Icons/asset-avatar.png"),
                    AssetClassID.BillboardAsset => GetBitmap("LunarsUABEA/Assets/Icons/asset-billboard.png"),
                    AssetClassID.BillboardRenderer => GetBitmap("LunarsUABEA/Assets/Icons/asset-billboard-renderer.png"),
                    AssetClassID.BoxCollider => GetBitmap("LunarsUABEA/Assets/Icons/asset-box-collider.png"),
                    AssetClassID.Camera => GetBitmap("LunarsUABEA/Assets/Icons/asset-camera.png"),
                    AssetClassID.Canvas => GetBitmap("LunarsUABEA/Assets/Icons/asset-canvas.png"),
                    AssetClassID.CanvasGroup => GetBitmap("LunarsUABEA/Assets/Icons/asset-canvas-group.png"),
                    AssetClassID.CanvasRenderer => GetBitmap("LunarsUABEA/Assets/Icons/asset-canvas-renderer.png"),
                    AssetClassID.CapsuleCollider => GetBitmap("LunarsUABEA/Assets/Icons/asset-capsule-collider.png"),
                    AssetClassID.CapsuleCollider2D => GetBitmap("LunarsUABEA/Assets/Icons/asset-capsule-collider.png"),
                    AssetClassID.ComputeShader => GetBitmap("LunarsUABEA/Assets/Icons/asset-compute-shader.png"),
                    AssetClassID.Cubemap => GetBitmap("LunarsUABEA/Assets/Icons/asset-cubemap.png"),
                    AssetClassID.Flare => GetBitmap("LunarsUABEA/Assets/Icons/asset-flare.png"),
                    AssetClassID.FlareLayer => GetBitmap("LunarsUABEA/Assets/Icons/asset-flare-layer.png"),
                    AssetClassID.Font => GetBitmap("LunarsUABEA/Assets/Icons/asset-font.png"),
                    AssetClassID.GameObject => GetBitmap("LunarsUABEA/Assets/Icons/asset-game-object.png"),
                    AssetClassID.Light => GetBitmap("LunarsUABEA/Assets/Icons/asset-light.png"),
                    AssetClassID.LightmapSettings => GetBitmap("LunarsUABEA/Assets/Icons/asset-lightmap-settings.png"),
                    AssetClassID.LODGroup => GetBitmap("LunarsUABEA/Assets/Icons/asset-lod-group.png"),
                    AssetClassID.Material => GetBitmap("LunarsUABEA/Assets/Icons/asset-material.png"),
                    AssetClassID.Mesh => GetBitmap("LunarsUABEA/Assets/Icons/asset-mesh.png"),
                    AssetClassID.MeshCollider => GetBitmap("LunarsUABEA/Assets/Icons/asset-mesh-collider.png"),
                    AssetClassID.MeshFilter => GetBitmap("LunarsUABEA/Assets/Icons/asset-mesh-filter.png"),
                    AssetClassID.MeshRenderer => GetBitmap("LunarsUABEA/Assets/Icons/asset-mesh-renderer.png"),
                    AssetClassID.MonoBehaviour => GetBitmap("LunarsUABEA/Assets/Icons/asset-mono-behaviour.png"),
                    AssetClassID.MonoScript => GetBitmap("LunarsUABEA/Assets/Icons/asset-mono-script.png"),
                    AssetClassID.NavMeshSettings => GetBitmap("LunarsUABEA/Assets/Icons/asset-nav-mesh-settings.png"),
                    AssetClassID.ParticleSystem => GetBitmap("LunarsUABEA/Assets/Icons/asset-particle-system.png"),
                    AssetClassID.ParticleSystemRenderer => GetBitmap("LunarsUABEA/Assets/Icons/asset-particle-system-renderer.png"),
                    AssetClassID.RectTransform => GetBitmap("LunarsUABEA/Assets/Icons/asset-rect-transform.png"),
                    AssetClassID.ReflectionProbe => GetBitmap("LunarsUABEA/Assets/Icons/asset-reflection-probe.png"),
                    AssetClassID.Rigidbody => GetBitmap("LunarsUABEA/Assets/Icons/asset-rigidbody.png"),
                    AssetClassID.Shader => GetBitmap("LunarsUABEA/Assets/Icons/asset-shader.png"),
                    AssetClassID.ShaderVariantCollection => GetBitmap("LunarsUABEA/Assets/Icons/asset-shader-collection.png"),
                    AssetClassID.SkinnedMeshRenderer => GetBitmap("LunarsUABEA/Assets/Icons/asset-mesh-renderer.png"), // todo
                    AssetClassID.Sprite => GetBitmap("LunarsUABEA/Assets/Icons/asset-sprite.png"),
                    AssetClassID.SpriteRenderer => GetBitmap("LunarsUABEA/Assets/Icons/asset-sprite-renderer.png"),
                    AssetClassID.Terrain => GetBitmap("LunarsUABEA/Assets/Icons/asset-terrain.png"),
                    AssetClassID.TerrainCollider => GetBitmap("LunarsUABEA/Assets/Icons/asset-terrain-collider.png"),
                    AssetClassID.TextAsset => GetBitmap("LunarsUABEA/Assets/Icons/asset-text-asset.png"),
                    AssetClassID.Texture2D => GetBitmap("LunarsUABEA/Assets/Icons/asset-texture2d.png"),
                    AssetClassID.Texture3D => GetBitmap("LunarsUABEA/Assets/Icons/asset-texture2d.png"),
                    AssetClassID.Transform => GetBitmap("LunarsUABEA/Assets/Icons/asset-transform.png"),
                    _ => GetBitmap("LunarsUABEA/Assets/Icons/asset-unknown.png"),
                };
            }

            return new BindingNotification(new InvalidCastException(), BindingErrorType.Error);
        }


        Dictionary<string, Bitmap> cache = new();

        private Bitmap GetBitmap(string path)
        {
            Bitmap? bitmap;
            if (cache.TryGetValue(path, out bitmap))
            {
                return bitmap;
            }
            else
            {
                bitmap = new Bitmap(AssetLoader.Open(new Uri($"avares://{path}")));
                cache[path] = bitmap;
                return bitmap;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
