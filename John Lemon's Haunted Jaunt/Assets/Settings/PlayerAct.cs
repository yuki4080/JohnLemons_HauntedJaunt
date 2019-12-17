// GENERATED AUTOMATICALLY FROM 'Assets/Settings/PlayerAct.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerAct : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public @PlayerAct()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerAct"",
    ""maps"": [
        {
            ""name"": ""JohnLemon"",
            ""id"": ""080aa898-a6ce-489a-af32-0012a2428981"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""cb618f3b-b4d2-4b60-afa6-b2807b4f0a88"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9beeeb68-bbda-483b-86d1-e9846d1f4037"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59ae0102-f1ac-49c8-b99b-72b9019a454a"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""wasd"",
                    ""id"": ""ff0663c7-319c-4490-836e-b57a31d560cc"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b1a791ed-7103-47aa-9d8d-0cab74d04245"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8090b5e6-45b4-4221-9ec4-b195ac4330ff"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4c81e29d-f460-4608-a1ae-73692ced1c50"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c9b6a10e-24a0-4ba1-87f2-ee64b4a7a040"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrow"",
                    ""id"": ""98537345-4778-4b7a-a2fd-e0f66ff38050"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""04bdea89-c82f-45cb-b528-132a3be698ee"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""5b60a888-fc2d-4d07-b977-f9f227394488"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0bbf41ea-f792-4b38-8273-f9efdcdf64bc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd4e8114-155a-4845-93a3-2bfe559e5862"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // JohnLemon
        m_JohnLemon = asset.FindActionMap("JohnLemon", throwIfNotFound: true);
        m_JohnLemon_Move = m_JohnLemon.FindAction("Move", throwIfNotFound: true);
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

    // JohnLemon
    private readonly InputActionMap m_JohnLemon;
    private IJohnLemonActions m_JohnLemonActionsCallbackInterface;
    private readonly InputAction m_JohnLemon_Move;
    public struct JohnLemonActions
    {
        private @PlayerAct m_Wrapper;
        public JohnLemonActions(@PlayerAct wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_JohnLemon_Move;
        public InputActionMap Get() { return m_Wrapper.m_JohnLemon; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(JohnLemonActions set) { return set.Get(); }
        public void SetCallbacks(IJohnLemonActions instance)
        {
            if (m_Wrapper.m_JohnLemonActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_JohnLemonActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_JohnLemonActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_JohnLemonActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_JohnLemonActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public JohnLemonActions @JohnLemon => new JohnLemonActions(this);
    public interface IJohnLemonActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
