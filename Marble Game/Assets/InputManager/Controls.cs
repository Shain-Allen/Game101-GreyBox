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
            ""name"": ""TableControl"",
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
                    ""type"": ""PassThrough"",
                    ""id"": ""5134a39f-9da2-4994-b8d0-8a223f89eeb8"",
                    ""expectedControlType"": ""Vector2"",
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
                    ""name"": """",
                    ""id"": ""918353b0-7614-4eac-b092-45376ad48983"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera Control"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // TableControl
        m_TableControl = asset.FindActionMap("TableControl", throwIfNotFound: true);
        m_TableControl_TableTilt = m_TableControl.FindAction("TableTilt", throwIfNotFound: true);
        m_TableControl_CameraControl = m_TableControl.FindAction("Camera Control", throwIfNotFound: true);
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

    // TableControl
    private readonly InputActionMap m_TableControl;
    private ITableControlActions m_TableControlActionsCallbackInterface;
    private readonly InputAction m_TableControl_TableTilt;
    private readonly InputAction m_TableControl_CameraControl;
    public struct TableControlActions
    {
        private @Controls m_Wrapper;
        public TableControlActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @TableTilt => m_Wrapper.m_TableControl_TableTilt;
        public InputAction @CameraControl => m_Wrapper.m_TableControl_CameraControl;
        public InputActionMap Get() { return m_Wrapper.m_TableControl; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TableControlActions set) { return set.Get(); }
        public void SetCallbacks(ITableControlActions instance)
        {
            if (m_Wrapper.m_TableControlActionsCallbackInterface != null)
            {
                @TableTilt.started -= m_Wrapper.m_TableControlActionsCallbackInterface.OnTableTilt;
                @TableTilt.performed -= m_Wrapper.m_TableControlActionsCallbackInterface.OnTableTilt;
                @TableTilt.canceled -= m_Wrapper.m_TableControlActionsCallbackInterface.OnTableTilt;
                @CameraControl.started -= m_Wrapper.m_TableControlActionsCallbackInterface.OnCameraControl;
                @CameraControl.performed -= m_Wrapper.m_TableControlActionsCallbackInterface.OnCameraControl;
                @CameraControl.canceled -= m_Wrapper.m_TableControlActionsCallbackInterface.OnCameraControl;
            }
            m_Wrapper.m_TableControlActionsCallbackInterface = instance;
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
    public TableControlActions @TableControl => new TableControlActions(this);
    public interface ITableControlActions
    {
        void OnTableTilt(InputAction.CallbackContext context);
        void OnCameraControl(InputAction.CallbackContext context);
    }
}
