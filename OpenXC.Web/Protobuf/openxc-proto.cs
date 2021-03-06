//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: openxc.proto
namespace openxc
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"VehicleMessage")]
  public partial class VehicleMessage : global::ProtoBuf.IExtensible
  {
    public VehicleMessage() {}
    
    private openxc.VehicleMessage.Type _type = openxc.VehicleMessage.Type.CAN;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.VehicleMessage.Type.CAN)]
    public openxc.VehicleMessage.Type type
    {
      get { return _type; }
      set { _type = value; }
    }
    private openxc.CanMessage _can_message = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"can_message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.CanMessage can_message
    {
      get { return _can_message; }
      set { _can_message = value; }
    }
    private openxc.SimpleMessage _simple_message = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"simple_message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.SimpleMessage simple_message
    {
      get { return _simple_message; }
      set { _simple_message = value; }
    }
    private openxc.DiagnosticResponse _diagnostic_response = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"diagnostic_response", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.DiagnosticResponse diagnostic_response
    {
      get { return _diagnostic_response; }
      set { _diagnostic_response = value; }
    }
    private openxc.ControlCommand _control_command = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"control_command", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.ControlCommand control_command
    {
      get { return _control_command; }
      set { _control_command = value; }
    }
    private openxc.CommandResponse _command_response = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"command_response", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.CommandResponse command_response
    {
      get { return _command_response; }
      set { _command_response = value; }
    }
    private uint _uptime = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"uptime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint uptime
    {
      get { return _uptime; }
      set { _uptime = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"Type")]
    public enum Type
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CAN", Value=1)]
      CAN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SIMPLE", Value=2)]
      SIMPLE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DIAGNOSTIC", Value=3)]
      DIAGNOSTIC = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CONTROL_COMMAND", Value=4)]
      CONTROL_COMMAND = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"COMMAND_RESPONSE", Value=5)]
      COMMAND_RESPONSE = 5
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CanMessage")]
  public partial class CanMessage : global::ProtoBuf.IExtensible
  {
    public CanMessage() {}
    
    private int _bus = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bus
    {
      get { return _bus; }
      set { _bus = value; }
    }
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private openxc.CanMessage.FrameFormat _frame_format = openxc.CanMessage.FrameFormat.STANDARD;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"frame_format", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.CanMessage.FrameFormat.STANDARD)]
    public openxc.CanMessage.FrameFormat frame_format
    {
      get { return _frame_format; }
      set { _frame_format = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"FrameFormat")]
    public enum FrameFormat
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"STANDARD", Value=1)]
      STANDARD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EXTENDED", Value=2)]
      EXTENDED = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ControlCommand")]
  public partial class ControlCommand : global::ProtoBuf.IExtensible
  {
    public ControlCommand() {}
    
    private openxc.ControlCommand.Type _type = openxc.ControlCommand.Type.VERSION;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.ControlCommand.Type.VERSION)]
    public openxc.ControlCommand.Type type
    {
      get { return _type; }
      set { _type = value; }
    }
    private openxc.DiagnosticControlCommand _diagnostic_request = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"diagnostic_request", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.DiagnosticControlCommand diagnostic_request
    {
      get { return _diagnostic_request; }
      set { _diagnostic_request = value; }
    }
    private openxc.PassthroughModeControlCommand _passthrough_mode_request = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"passthrough_mode_request", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.PassthroughModeControlCommand passthrough_mode_request
    {
      get { return _passthrough_mode_request; }
      set { _passthrough_mode_request = value; }
    }
    private openxc.AcceptanceFilterBypassCommand _acceptance_filter_bypass_command = null;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"acceptance_filter_bypass_command", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.AcceptanceFilterBypassCommand acceptance_filter_bypass_command
    {
      get { return _acceptance_filter_bypass_command; }
      set { _acceptance_filter_bypass_command = value; }
    }
    private openxc.PayloadFormatCommand _payload_format_command = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"payload_format_command", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.PayloadFormatCommand payload_format_command
    {
      get { return _payload_format_command; }
      set { _payload_format_command = value; }
    }
    private openxc.PredefinedObd2RequestsCommand _predefined_obd2_requests_command = null;
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"predefined_obd2_requests_command", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.PredefinedObd2RequestsCommand predefined_obd2_requests_command
    {
      get { return _predefined_obd2_requests_command; }
      set { _predefined_obd2_requests_command = value; }
    }
    private openxc.ModemConfigurationCommand _modem_configuration_command = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"modem_configuration_command", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.ModemConfigurationCommand modem_configuration_command
    {
      get { return _modem_configuration_command; }
      set { _modem_configuration_command = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"Type")]
    public enum Type
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"VERSION", Value=1)]
      VERSION = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEVICE_ID", Value=2)]
      DEVICE_ID = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DIAGNOSTIC", Value=3)]
      DIAGNOSTIC = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PASSTHROUGH", Value=4)]
      PASSTHROUGH = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ACCEPTANCE_FILTER_BYPASS", Value=5)]
      ACCEPTANCE_FILTER_BYPASS = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PAYLOAD_FORMAT", Value=6)]
      PAYLOAD_FORMAT = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PREDEFINED_OBD2_REQUESTS", Value=7)]
      PREDEFINED_OBD2_REQUESTS = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MODEM_CONFIGURATION", Value=8)]
      MODEM_CONFIGURATION = 8
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DiagnosticControlCommand")]
  public partial class DiagnosticControlCommand : global::ProtoBuf.IExtensible
  {
    public DiagnosticControlCommand() {}
    
    private openxc.DiagnosticRequest _request = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"request", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.DiagnosticRequest request
    {
      get { return _request; }
      set { _request = value; }
    }
    private openxc.DiagnosticControlCommand.Action _action = openxc.DiagnosticControlCommand.Action.ADD;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"action", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.DiagnosticControlCommand.Action.ADD)]
    public openxc.DiagnosticControlCommand.Action action
    {
      get { return _action; }
      set { _action = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"Action")]
    public enum Action
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ADD", Value=1)]
      ADD = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CANCEL", Value=2)]
      CANCEL = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PassthroughModeControlCommand")]
  public partial class PassthroughModeControlCommand : global::ProtoBuf.IExtensible
  {
    public PassthroughModeControlCommand() {}
    
    private int _bus = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bus
    {
      get { return _bus; }
      set { _bus = value; }
    }
    private bool _enabled = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"enabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool enabled
    {
      get { return _enabled; }
      set { _enabled = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AcceptanceFilterBypassCommand")]
  public partial class AcceptanceFilterBypassCommand : global::ProtoBuf.IExtensible
  {
    public AcceptanceFilterBypassCommand() {}
    
    private int _bus = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bus
    {
      get { return _bus; }
      set { _bus = value; }
    }
    private bool _bypass = default(bool);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"bypass", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool bypass
    {
      get { return _bypass; }
      set { _bypass = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PayloadFormatCommand")]
  public partial class PayloadFormatCommand : global::ProtoBuf.IExtensible
  {
    public PayloadFormatCommand() {}
    
    private openxc.PayloadFormatCommand.PayloadFormat _format = openxc.PayloadFormatCommand.PayloadFormat.JSON;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"format", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.PayloadFormatCommand.PayloadFormat.JSON)]
    public openxc.PayloadFormatCommand.PayloadFormat format
    {
      get { return _format; }
      set { _format = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"PayloadFormat")]
    public enum PayloadFormat
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"JSON", Value=1)]
      JSON = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PROTOBUF", Value=2)]
      PROTOBUF = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PredefinedObd2RequestsCommand")]
  public partial class PredefinedObd2RequestsCommand : global::ProtoBuf.IExtensible
  {
    public PredefinedObd2RequestsCommand() {}
    
    private bool _enabled = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"enabled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool enabled
    {
      get { return _enabled; }
      set { _enabled = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NetworkOperatorSettings")]
  public partial class NetworkOperatorSettings : global::ProtoBuf.IExtensible
  {
    public NetworkOperatorSettings() {}
    
    private bool _allowDataRoaming = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"allowDataRoaming", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool allowDataRoaming
    {
      get { return _allowDataRoaming; }
      set { _allowDataRoaming = value; }
    }
    private openxc.NetworkOperatorSettings.OperatorSelectMode _operatorSelectMode = openxc.NetworkOperatorSettings.OperatorSelectMode.AUTOMATIC;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"operatorSelectMode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.NetworkOperatorSettings.OperatorSelectMode.AUTOMATIC)]
    public openxc.NetworkOperatorSettings.OperatorSelectMode operatorSelectMode
    {
      get { return _operatorSelectMode; }
      set { _operatorSelectMode = value; }
    }
    private openxc.NetworkOperatorSettings.NetworkDescriptor _networkDescriptor = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"networkDescriptor", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.NetworkOperatorSettings.NetworkDescriptor networkDescriptor
    {
      get { return _networkDescriptor; }
      set { _networkDescriptor = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NetworkDescriptor")]
  public partial class NetworkDescriptor : global::ProtoBuf.IExtensible
  {
    public NetworkDescriptor() {}
    
    private uint _PLMN = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"PLMN", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint PLMN
    {
      get { return _PLMN; }
      set { _PLMN = value; }
    }
    private openxc.NetworkOperatorSettings.NetworkDescriptor.NetworkType _networkType = openxc.NetworkOperatorSettings.NetworkDescriptor.NetworkType.GSM;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"networkType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.NetworkOperatorSettings.NetworkDescriptor.NetworkType.GSM)]
    public openxc.NetworkOperatorSettings.NetworkDescriptor.NetworkType networkType
    {
      get { return _networkType; }
      set { _networkType = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"NetworkType")]
    public enum NetworkType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"GSM", Value=0)]
      GSM = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"UTRAN", Value=2)]
      UTRAN = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"OperatorSelectMode")]
    public enum OperatorSelectMode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"AUTOMATIC", Value=0)]
      AUTOMATIC = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MANUAL", Value=1)]
      MANUAL = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"DEREGISTER", Value=2)]
      DEREGISTER = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SET_ONLY", Value=3)]
      SET_ONLY = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MANUAL_AUTOMATIC", Value=4)]
      MANUAL_AUTOMATIC = 4
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NetworkDataSettings")]
  public partial class NetworkDataSettings : global::ProtoBuf.IExtensible
  {
    public NetworkDataSettings() {}
    
    private string _APN = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"APN", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string APN
    {
      get { return _APN; }
      set { _APN = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ServerConnectSettings")]
  public partial class ServerConnectSettings : global::ProtoBuf.IExtensible
  {
    public ServerConnectSettings() {}
    
    private string _host = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"host", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string host
    {
      get { return _host; }
      set { _host = value; }
    }
    private uint _port = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint port
    {
      get { return _port; }
      set { _port = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ModemConfigurationCommand")]
  public partial class ModemConfigurationCommand : global::ProtoBuf.IExtensible
  {
    public ModemConfigurationCommand() {}
    
    private openxc.NetworkOperatorSettings _networkOperatorSettings = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"networkOperatorSettings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.NetworkOperatorSettings networkOperatorSettings
    {
      get { return _networkOperatorSettings; }
      set { _networkOperatorSettings = value; }
    }
    private openxc.NetworkDataSettings _networkDataSettings = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"networkDataSettings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.NetworkDataSettings networkDataSettings
    {
      get { return _networkDataSettings; }
      set { _networkDataSettings = value; }
    }
    private openxc.ServerConnectSettings _serverConnectSettings = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"serverConnectSettings", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.ServerConnectSettings serverConnectSettings
    {
      get { return _serverConnectSettings; }
      set { _serverConnectSettings = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CommandResponse")]
  public partial class CommandResponse : global::ProtoBuf.IExtensible
  {
    public CommandResponse() {}
    
    private openxc.ControlCommand.Type _type = openxc.ControlCommand.Type.VERSION;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.ControlCommand.Type.VERSION)]
    public openxc.ControlCommand.Type type
    {
      get { return _type; }
      set { _type = value; }
    }
    private string _message = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string message
    {
      get { return _message; }
      set { _message = value; }
    }
    private bool _status = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DiagnosticRequest")]
  public partial class DiagnosticRequest : global::ProtoBuf.IExtensible
  {
    public DiagnosticRequest() {}
    
    private int _bus = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bus
    {
      get { return _bus; }
      set { _bus = value; }
    }
    private uint _message_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"message_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint message_id
    {
      get { return _message_id; }
      set { _message_id = value; }
    }
    private uint _mode = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"mode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mode
    {
      get { return _mode; }
      set { _mode = value; }
    }
    private uint _pid = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"pid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pid
    {
      get { return _pid; }
      set { _pid = value; }
    }
    private byte[] _payload = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"payload", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] payload
    {
      get { return _payload; }
      set { _payload = value; }
    }
    private bool _multiple_responses = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"multiple_responses", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool multiple_responses
    {
      get { return _multiple_responses; }
      set { _multiple_responses = value; }
    }
    private double _frequency = default(double);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"frequency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double frequency
    {
      get { return _frequency; }
      set { _frequency = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private openxc.DiagnosticRequest.DecodedType _decoded_type = openxc.DiagnosticRequest.DecodedType.NONE;
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"decoded_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.DiagnosticRequest.DecodedType.NONE)]
    public openxc.DiagnosticRequest.DecodedType decoded_type
    {
      get { return _decoded_type; }
      set { _decoded_type = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"DecodedType")]
    public enum DecodedType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NONE", Value=1)]
      NONE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OBD2", Value=2)]
      OBD2 = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DiagnosticResponse")]
  public partial class DiagnosticResponse : global::ProtoBuf.IExtensible
  {
    public DiagnosticResponse() {}
    
    private int _bus = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"bus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int bus
    {
      get { return _bus; }
      set { _bus = value; }
    }
    private uint _message_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"message_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint message_id
    {
      get { return _message_id; }
      set { _message_id = value; }
    }
    private uint _mode = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"mode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint mode
    {
      get { return _mode; }
      set { _mode = value; }
    }
    private uint _pid = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"pid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint pid
    {
      get { return _pid; }
      set { _pid = value; }
    }
    private bool _success = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"success", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool success
    {
      get { return _success; }
      set { _success = value; }
    }
    private uint _negative_response_code = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"negative_response_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint negative_response_code
    {
      get { return _negative_response_code; }
      set { _negative_response_code = value; }
    }
    private byte[] _payload = null;
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"payload", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] payload
    {
      get { return _payload; }
      set { _payload = value; }
    }
    private double _value = default(double);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DynamicField")]
  public partial class DynamicField : global::ProtoBuf.IExtensible
  {
    public DynamicField() {}
    
    private openxc.DynamicField.Type _type = openxc.DynamicField.Type.STRING;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(openxc.DynamicField.Type.STRING)]
    public openxc.DynamicField.Type type
    {
      get { return _type; }
      set { _type = value; }
    }
    private string _string_value = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"string_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string string_value
    {
      get { return _string_value; }
      set { _string_value = value; }
    }
    private double _numeric_value = default(double);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"numeric_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(double))]
    public double numeric_value
    {
      get { return _numeric_value; }
      set { _numeric_value = value; }
    }
    private bool _boolean_value = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"boolean_value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool boolean_value
    {
      get { return _boolean_value; }
      set { _boolean_value = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"Type")]
    public enum Type
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"STRING", Value=1)]
      STRING = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NUM", Value=2)]
      NUM = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"BOOL", Value=3)]
      BOOL = 3
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SimpleMessage")]
  public partial class SimpleMessage : global::ProtoBuf.IExtensible
  {
    public SimpleMessage() {}
    
    private string _name = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private openxc.DynamicField _value = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.DynamicField value
    {
      get { return _value; }
      set { _value = value; }
    }
    private openxc.DynamicField _event = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"event", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public openxc.DynamicField @event
    {
      get { return _event; }
      set { _event = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}