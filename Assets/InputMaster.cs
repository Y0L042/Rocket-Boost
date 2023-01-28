//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputMaster.inputactions
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

public partial class @InputMaster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Rocket"",
            ""id"": ""917c90bc-f909-4226-8c4f-f7d146692851"",
            ""actions"": [
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Value"",
                    ""id"": ""dfb125e8-8336-4715-b826-906df6a6f7d1"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Turn"",
                    ""type"": ""Value"",
                    ""id"": ""1b178fc5-8381-4a46-a0c0-91af2df0dc58"",
                    ""expectedControlType"": ""Analog"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""DT_NextLevel"",
                    ""type"": ""Button"",
                    ""id"": ""f1f6bf17-7d00-4097-ad71-7f409ec3b9c3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DT_RestartLevel"",
                    ""type"": ""Button"",
                    ""id"": ""7f06b7c2-ffc1-4806-83df-266919584c46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DT_Reset Spaceship"",
                    ""type"": ""Button"",
                    ""id"": ""00f68391-3c43-4f2e-9751-0b107af4f70c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""DT_Invincible"",
                    ""type"": ""Button"",
                    ""id"": ""ccada652-f1d6-467d-a181-d409b0eeb5d3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""a49aea4f-ae1a-497c-b111-19a0f5e612fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e5c79e0f-d4a2-4158-8133-adec372a16c7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac4a499c-13ca-47b3-8da8-4f27297994d0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8f4ab770-daec-4b9c-97bd-ab3767d87288"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""44469dd5-1c53-4bd2-8c2d-ef0d3dd1ac41"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""810e280d-2821-4b89-b9c3-cc5d44f8de4d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""972b3d7f-18be-4171-96cb-5d29970451ab"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1cfae08d-e0bb-4121-b7cf-c0cf5b3783e7"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Turn"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""466b4d73-34a9-4dee-9a19-0f3a3c482a85"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8432da58-ccad-47c1-810e-289558ab84c9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c11aae4e-0e1c-47a6-b8c0-bdce5ccc5929"",
                    ""path"": ""<Keyboard>/l"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""DT_NextLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2eaafe4a-3c93-4e24-a97b-b09a36141381"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""DT_RestartLevel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15766002-8318-40dc-8a22-4a10930e68ff"",
                    ""path"": ""<Keyboard>/o"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""DT_Reset Spaceship"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdf931b3-24d8-41e8-a4fb-f9e93386d5b0"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""DT_Invincible"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""510465ff-3f85-4e3d-b374-1f850792f720"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2ca212f5-5168-4829-a771-6087f489e0b8"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Rocket
        m_Rocket = asset.FindActionMap("Rocket", throwIfNotFound: true);
        m_Rocket_Thrust = m_Rocket.FindAction("Thrust", throwIfNotFound: true);
        m_Rocket_Turn = m_Rocket.FindAction("Turn", throwIfNotFound: true);
        m_Rocket_DT_NextLevel = m_Rocket.FindAction("DT_NextLevel", throwIfNotFound: true);
        m_Rocket_DT_RestartLevel = m_Rocket.FindAction("DT_RestartLevel", throwIfNotFound: true);
        m_Rocket_DT_ResetSpaceship = m_Rocket.FindAction("DT_Reset Spaceship", throwIfNotFound: true);
        m_Rocket_DT_Invincible = m_Rocket.FindAction("DT_Invincible", throwIfNotFound: true);
        m_Rocket_Escape = m_Rocket.FindAction("Escape", throwIfNotFound: true);
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

    // Rocket
    private readonly InputActionMap m_Rocket;
    private IRocketActions m_RocketActionsCallbackInterface;
    private readonly InputAction m_Rocket_Thrust;
    private readonly InputAction m_Rocket_Turn;
    private readonly InputAction m_Rocket_DT_NextLevel;
    private readonly InputAction m_Rocket_DT_RestartLevel;
    private readonly InputAction m_Rocket_DT_ResetSpaceship;
    private readonly InputAction m_Rocket_DT_Invincible;
    private readonly InputAction m_Rocket_Escape;
    public struct RocketActions
    {
        private @InputMaster m_Wrapper;
        public RocketActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_Rocket_Thrust;
        public InputAction @Turn => m_Wrapper.m_Rocket_Turn;
        public InputAction @DT_NextLevel => m_Wrapper.m_Rocket_DT_NextLevel;
        public InputAction @DT_RestartLevel => m_Wrapper.m_Rocket_DT_RestartLevel;
        public InputAction @DT_ResetSpaceship => m_Wrapper.m_Rocket_DT_ResetSpaceship;
        public InputAction @DT_Invincible => m_Wrapper.m_Rocket_DT_Invincible;
        public InputAction @Escape => m_Wrapper.m_Rocket_Escape;
        public InputActionMap Get() { return m_Wrapper.m_Rocket; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RocketActions set) { return set.Get(); }
        public void SetCallbacks(IRocketActions instance)
        {
            if (m_Wrapper.m_RocketActionsCallbackInterface != null)
            {
                @Thrust.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnThrust;
                @Thrust.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnThrust;
                @Thrust.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnThrust;
                @Turn.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnTurn;
                @Turn.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnTurn;
                @Turn.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnTurn;
                @DT_NextLevel.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_NextLevel;
                @DT_NextLevel.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_NextLevel;
                @DT_NextLevel.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_NextLevel;
                @DT_RestartLevel.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_RestartLevel;
                @DT_RestartLevel.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_RestartLevel;
                @DT_RestartLevel.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_RestartLevel;
                @DT_ResetSpaceship.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_ResetSpaceship;
                @DT_ResetSpaceship.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_ResetSpaceship;
                @DT_ResetSpaceship.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_ResetSpaceship;
                @DT_Invincible.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_Invincible;
                @DT_Invincible.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_Invincible;
                @DT_Invincible.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnDT_Invincible;
                @Escape.started -= m_Wrapper.m_RocketActionsCallbackInterface.OnEscape;
                @Escape.performed -= m_Wrapper.m_RocketActionsCallbackInterface.OnEscape;
                @Escape.canceled -= m_Wrapper.m_RocketActionsCallbackInterface.OnEscape;
            }
            m_Wrapper.m_RocketActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Thrust.started += instance.OnThrust;
                @Thrust.performed += instance.OnThrust;
                @Thrust.canceled += instance.OnThrust;
                @Turn.started += instance.OnTurn;
                @Turn.performed += instance.OnTurn;
                @Turn.canceled += instance.OnTurn;
                @DT_NextLevel.started += instance.OnDT_NextLevel;
                @DT_NextLevel.performed += instance.OnDT_NextLevel;
                @DT_NextLevel.canceled += instance.OnDT_NextLevel;
                @DT_RestartLevel.started += instance.OnDT_RestartLevel;
                @DT_RestartLevel.performed += instance.OnDT_RestartLevel;
                @DT_RestartLevel.canceled += instance.OnDT_RestartLevel;
                @DT_ResetSpaceship.started += instance.OnDT_ResetSpaceship;
                @DT_ResetSpaceship.performed += instance.OnDT_ResetSpaceship;
                @DT_ResetSpaceship.canceled += instance.OnDT_ResetSpaceship;
                @DT_Invincible.started += instance.OnDT_Invincible;
                @DT_Invincible.performed += instance.OnDT_Invincible;
                @DT_Invincible.canceled += instance.OnDT_Invincible;
                @Escape.started += instance.OnEscape;
                @Escape.performed += instance.OnEscape;
                @Escape.canceled += instance.OnEscape;
            }
        }
    }
    public RocketActions @Rocket => new RocketActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IRocketActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnDT_NextLevel(InputAction.CallbackContext context);
        void OnDT_RestartLevel(InputAction.CallbackContext context);
        void OnDT_ResetSpaceship(InputAction.CallbackContext context);
        void OnDT_Invincible(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
    }
}
