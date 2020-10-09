// GENERATED AUTOMATICALLY FROM 'Assets/InputManager/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""TiltTable"",
            ""id"": ""a42f46ac-c223-4017-9842-d3b30d890378"",
            ""actions"": [
                {
                    ""name"": ""TableTilt"",
                    ""type"": ""Value"",
                    ""id"": ""9a52a8cf-a167-47b8-be58-5fc4a9649ea9"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Camera Control"",
                    ""type"": ""Button"",
                    ""id"": ""5134a39f-9da2-4994-b8d0-8a223f89eeb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""0e36f383-c8a9-42b4-8c78-8a18f15c5c95"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TableTilt"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""94db3e5d-ffba-43c2-88f6-17c9d4411cb5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TableTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9874f391-57a5-4dc5-87c3-23b60fcd63c8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TableTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bc3fb06e-5308-40dd-98a4-f232ddbc0985"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TableTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""afb9bb30-2d1b-48ab-8e27-3ed523b04e4c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TableTilt"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Mouse"",
                    ""id"": ""41f76a2b-52b8-4c31-842e-d9d190f0eb8c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Control"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""50152a4e-cd62-41f3-b5c2-bc8d4d36b405"",
                    ""path"": ""<Mouse>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""38d24aa3-0f9e-4cf8-9c37-e1b617b7f3f5"",
                    ""path"": ""<Mouse>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TiltTable
        m_TiltTable = asset.FindActionMap("TiltTable", throwIfNotFound: true);
        m_TiltTable_TableTilt = m_TiltTable.FindAction("TableTilt", throwIfNotFound: true);
        m_TiltTable_CameraControl = m_TiltTable.FindAction("Camera Control", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // TiltTable
    private readonly InputActionMap m_TiltTable;
    private ITiltTableActions m_TiltTableActionsCallbackInterface;
    private readonly InputAction m_TiltTable_TableTilt;
    private readonly InputAction m_TiltTable_CameraControl;
    public struct TiltTableActions
    {
        private @Controls m_Wrapper;
        public TiltTableActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @TableTilt => m_Wrapper.m_TiltTable_TableTilt;
        public InputAction @CameraControl => m_Wrapper.m_TiltTable_CameraControl;
        public InputActionMap Get() { return m_Wrapper.m_TiltTable; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TiltTableActions set) { return set.Get(); }
        public void SetCallbacks(ITiltTableActions instance)
        {
            if (m_Wrapper.m_TiltTableActionsCallbackInterface != null)
            {
                @TableTilt.started -= m_Wrapper.m_TiltTableActionsCallbackInterface.OnTableTilt;
                @TableTilt.performed -= m_Wrapper.m_TiltTableActionsCallbackInterface.OnTableTilt;
                @TableTilt.canceled -= m_Wrapper.m_TiltTableActionsCallbackInterface.OnTableTilt;
                @CameraControl.started -= m_Wrapper.m_TiltTableActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_TiltTableActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_TiltTableActionsCallbackInterface.OnCameraControl;
            }
            m_Wrapper.m_TiltTableActionsCallbackInterface = instance;
            if (instance != null)
            {
                @TableTilt.started += instance.OnTableTilt;
                @TableTilt.performed += instance.OnTableTilt;
                @TableTilt.canceled += instance.OnTableTilt;
                @CameraControl.started += instance.OnCameraControl;
                @CameraControl.performed += instance.OnCameraControl;
                @CameraControl.canceled += instance.OnCameraControl;
            }
        }
    }
    public TiltTableActions @TiltTable => new TiltTableActions(this);
    public interface ITiltTableActions
    {
        void OnTableTilt(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
    }
}
