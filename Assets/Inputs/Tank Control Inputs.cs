//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/Tank Control Inputs.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @TankControlInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TankControlInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Tank Control Inputs"",
    ""maps"": [
        {
            ""name"": ""Tank"",
            ""id"": ""28efc608-4fc8-4f46-915b-f576f6b8a6d6"",
            ""actions"": [
                {
                    ""name"": ""Left Tread"",
                    ""type"": ""Value"",
                    ""id"": ""467a554c-2e12-4688-919b-13a189711cc7"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Right Tread"",
                    ""type"": ""Value"",
                    ""id"": ""f81b07a8-f8c1-4d0c-9d33-57863d08ac41"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Turret"",
                    ""type"": ""PassThrough"",
                    ""id"": ""507b6e07-ebb0-4878-ae31-a42130ef80b3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""fe66b457-e9fe-4c22-9490-aa08146259b6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""55aca4b3-59fc-4763-859b-f40baefd8c8a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Tread"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""afaa51fa-dc4f-4c0c-9b06-7275db00da1e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Tread"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""6f38007b-b91f-40df-b506-d078c6c2d0af"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Tread"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""71dfae2f-ef5c-4531-b5f4-e927f53d30a1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Tread"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1d43512c-6ed7-41ca-9c08-54dfa13fefd7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Tread"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""63817e96-dbfc-40f9-8de0-1e4d2a7ebee7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left Tread"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1da24f8f-1020-4c93-9a91-a9f12bb8ce09"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6ef7df79-6570-4370-9b8d-764d6c0068b7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""280fe2e1-3f27-4257-b6cb-090e14efbe67"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Tread"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""45a1d9fb-7981-4df1-ac0a-b1074d7be850"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Tread"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""af8ce64e-588f-485c-ab23-ff5bc6f6cf98"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Tread"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d3f43e5c-137e-4341-85b1-720bca9115c6"",
                    ""path"": ""<HID::Logitech Logitech Dual Action>/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Tread"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""a12ea799-ca8e-4189-9423-b83691171f0e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""72617727-d734-4cf9-ba76-4b687efb77d6"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""eb46f703-effa-468e-b800-8c9ed6514ed6"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""726fc2c7-1472-4056-82dd-f6176430f5ec"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3d63d258-35b1-4983-9f0c-7d4f6653ddb2"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""4dc2a74a-c9b5-4951-a1a6-bf87305e10f1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e246b501-df21-4d77-ae56-e29ffe0ca5ae"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e3b5e1d1-daed-4063-9e83-87a4af6278cf"",
                    ""path"": ""<Keyboard>/v"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""1408d851-9310-4781-b9c9-88f8790f9d1f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""02873a37-7986-44f9-b02d-599abedc0a1c"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turret"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Tank
        m_Tank = asset.FindActionMap("Tank", throwIfNotFound: true);
        m_Tank_LeftTread = m_Tank.FindAction("Left Tread", throwIfNotFound: true);
        m_Tank_RightTread = m_Tank.FindAction("Right Tread", throwIfNotFound: true);
        m_Tank_Turret = m_Tank.FindAction("Turret", throwIfNotFound: true);
        m_Tank_Fire = m_Tank.FindAction("Fire", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Tank
    private readonly InputActionMap m_Tank;
    private List<ITankActions> m_TankActionsCallbackInterfaces = new List<ITankActions>();
    private readonly InputAction m_Tank_LeftTread;
    private readonly InputAction m_Tank_RightTread;
    private readonly InputAction m_Tank_Turret;
    private readonly InputAction m_Tank_Fire;
    public struct TankActions
    {
        private @TankControlInputs m_Wrapper;
        public TankActions(@TankControlInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @LeftTread => m_Wrapper.m_Tank_LeftTread;
        public InputAction @RightTread => m_Wrapper.m_Tank_RightTread;
        public InputAction @Turret => m_Wrapper.m_Tank_Turret;
        public InputAction @Fire => m_Wrapper.m_Tank_Fire;
        public InputActionMap Get() { return m_Wrapper.m_Tank; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TankActions set) { return set.Get(); }
        public void AddCallbacks(ITankActions instance)
        {
            if (instance == null || m_Wrapper.m_TankActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TankActionsCallbackInterfaces.Add(instance);
            @LeftTread.started += instance.OnLeftTread;
            @LeftTread.performed += instance.OnLeftTread;
            @LeftTread.canceled += instance.OnLeftTread;
            @RightTread.started += instance.OnRightTread;
            @RightTread.performed += instance.OnRightTread;
            @RightTread.canceled += instance.OnRightTread;
            @Turret.started += instance.OnTurret;
            @Turret.performed += instance.OnTurret;
            @Turret.canceled += instance.OnTurret;
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
        }

        private void UnregisterCallbacks(ITankActions instance)
        {
            @LeftTread.started -= instance.OnLeftTread;
            @LeftTread.performed -= instance.OnLeftTread;
            @LeftTread.canceled -= instance.OnLeftTread;
            @RightTread.started -= instance.OnRightTread;
            @RightTread.performed -= instance.OnRightTread;
            @RightTread.canceled -= instance.OnRightTread;
            @Turret.started -= instance.OnTurret;
            @Turret.performed -= instance.OnTurret;
            @Turret.canceled -= instance.OnTurret;
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
        }

        public void RemoveCallbacks(ITankActions instance)
        {
            if (m_Wrapper.m_TankActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITankActions instance)
        {
            foreach (var item in m_Wrapper.m_TankActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TankActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TankActions @Tank => new TankActions(this);
    public interface ITankActions
    {
        void OnLeftTread(InputAction.CallbackContext context);
        void OnRightTread(InputAction.CallbackContext context);
        void OnTurret(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
    }
}
