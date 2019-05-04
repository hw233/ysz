/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace RakNet {

using System;
using System.Runtime.InteropServices;

public class RakNet {
 
	    public static readonly SystemAddress UNASSIGNED_SYSTEM_ADDRESS = new SystemAddress();
	    public static readonly RakNetGUID UNASSIGNED_RAKNET_GUID = new RakNetGUID(ulong.MaxValue);

	    public static void StatisticsToString(RakNetStatistics s, out string buffer, int verbosityLevel) 
 	   {
		String tmp = new String('c', 9999);
		buffer=StatisticsToStringHelper(s,tmp,verbosityLevel);
 	   }
	
  public static string StatisticsToStringHelper(RakNetStatistics s, string buffer, int verbosityLevel) {
    string ret = RakNetPINVOKE.StatisticsToStringHelper(RakNetStatistics.getCPtr(s), buffer, verbosityLevel);
    return ret;
  }

  public static int MAX_RPC_MAP_SIZE {
    get {
      int ret = RakNetPINVOKE.MAX_RPC_MAP_SIZE_get();
      return ret;
    } 
  }

  public static int UNDEFINED_RPC_INDEX {
    get {
      int ret = RakNetPINVOKE.UNDEFINED_RPC_INDEX_get();
      return ret;
    } 
  }

  public static bool NonNumericHostString(string host) {
    bool ret = RakNetPINVOKE.NonNumericHostString(host);
    return ret;
  }

  public static ushort UNASSIGNED_PLAYER_INDEX {
    get {
      ushort ret = RakNetPINVOKE.UNASSIGNED_PLAYER_INDEX_get();
      return ret;
    } 
  }

  public static ulong UNASSIGNED_NETWORK_ID {
    get {
      ulong ret = RakNetPINVOKE.UNASSIGNED_NETWORK_ID_get();
      return ret;
    } 
  }

  public static int PING_TIMES_ARRAY_SIZE {
    get {
      int ret = RakNetPINVOKE.PING_TIMES_ARRAY_SIZE_get();
      return ret;
    } 
  }

  public static RakString OpPlus(RakString lhs, RakString rhs) {
    RakString ret = new RakString(RakNetPINVOKE.OpPlus__SWIG_0(RakString.getCPtr(lhs), RakString.getCPtr(rhs)), true);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

//  private static RakWString OpPlus(RakWString lhs, RakWString rhs) {
//    RakWString ret = new RakWString(RakNetPINVOKE.OpPlus__SWIG_1(RakWString.getCPtr(lhs), RakWString.getCPtr(rhs)), true);
//    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
//    return ret;
//  }

  public static uint MAX_UNSIGNED_LONG {
    get {
      uint ret = RakNetPINVOKE.MAX_UNSIGNED_LONG_get();
      return ret;
    } 
  }

  public static ulong GetTime() {
    ulong ret = RakNetPINVOKE.GetTime();
    return ret;
  }

  public static uint GetTimeMS() {
    uint ret = RakNetPINVOKE.GetTimeMS();
    return ret;
  }

  public static ulong GetTimeUS() {
    ulong ret = RakNetPINVOKE.GetTimeUS();
    return ret;
  }

  public static bool GreaterThan(ulong a, ulong b) {
    bool ret = RakNetPINVOKE.GreaterThan(a, b);
    return ret;
  }

  public static bool LessThan(ulong a, ulong b) {
    bool ret = RakNetPINVOKE.LessThan(a, b);
    return ret;
  }

  public static readonly int SWIG_CSHARP_NO_IMCLASS_STATIC_CONSTRUCTOR = RakNetPINVOKE.SWIG_CSHARP_NO_IMCLASS_STATIC_CONSTRUCTOR_get();
  public static readonly int __GET_TIME_64BIT = RakNetPINVOKE.__GET_TIME_64BIT_get();
  public static readonly int MAX_ALLOCA_STACK_ALLOCATION = RakNetPINVOKE.MAX_ALLOCA_STACK_ALLOCATION_get();
  public static readonly int _USE_RAK_MEMORY_OVERRIDE = RakNetPINVOKE._USE_RAK_MEMORY_OVERRIDE_get();
  public static readonly int OPEN_SSL_CLIENT_SUPPORT = RakNetPINVOKE.OPEN_SSL_CLIENT_SUPPORT_get();
  public static readonly int BITSTREAM_STACK_ALLOCATION_SIZE = RakNetPINVOKE.BITSTREAM_STACK_ALLOCATION_SIZE_get();
  public static readonly int MAXIMUM_NUMBER_OF_INTERNAL_IDS = RakNetPINVOKE.MAXIMUM_NUMBER_OF_INTERNAL_IDS_get();
  public static readonly int DATAGRAM_MESSAGE_ID_ARRAY_LENGTH = RakNetPINVOKE.DATAGRAM_MESSAGE_ID_ARRAY_LENGTH_get();
  public static readonly int RESEND_BUFFER_ARRAY_LENGTH = RakNetPINVOKE.RESEND_BUFFER_ARRAY_LENGTH_get();
  public static readonly int RESEND_BUFFER_ARRAY_MASK = RakNetPINVOKE.RESEND_BUFFER_ARRAY_MASK_get();
  public static readonly int GET_TIME_SPIKE_LIMIT = RakNetPINVOKE.GET_TIME_SPIKE_LIMIT_get();
  public static readonly int USE_SLIDING_WINDOW_CONGESTION_CONTROL = RakNetPINVOKE.USE_SLIDING_WINDOW_CONGESTION_CONTROL_get();
  public static readonly int PREALLOCATE_LARGE_MESSAGES = RakNetPINVOKE.PREALLOCATE_LARGE_MESSAGES_get();
  public static readonly int RAKNET_SUPPORT_IPV6 = RakNetPINVOKE.RAKNET_SUPPORT_IPV6_get();
  public static readonly int RAKSTRING_TYPE_IS_UNICODE = RakNetPINVOKE.RAKSTRING_TYPE_IS_UNICODE_get();
  public static readonly int RPC4_GLOBAL_REGISTRATION_MAX_FUNCTIONS = RakNetPINVOKE.RPC4_GLOBAL_REGISTRATION_MAX_FUNCTIONS_get();
  public static readonly int RPC4_GLOBAL_REGISTRATION_MAX_FUNCTION_NAME_LENGTH = RakNetPINVOKE.RPC4_GLOBAL_REGISTRATION_MAX_FUNCTION_NAME_LENGTH_get();
  public static readonly int XBOX_BYPASS_SECURITY = RakNetPINVOKE.XBOX_BYPASS_SECURITY_get();
  public static readonly int BUFFERED_PACKETS_PAGE_SIZE = RakNetPINVOKE.BUFFERED_PACKETS_PAGE_SIZE_get();
  public static readonly int INTERNAL_PACKET_PAGE_SIZE = RakNetPINVOKE.INTERNAL_PACKET_PAGE_SIZE_get();
  public static readonly int RAKPEER_USER_THREADED = RakNetPINVOKE.RAKPEER_USER_THREADED_get();
  public static readonly int USE_ALLOCA = RakNetPINVOKE.USE_ALLOCA_get();
  public static readonly int LIBCAT_SECURITY = RakNetPINVOKE.LIBCAT_SECURITY_get();
  public static readonly int _RAKNET_SUPPORT_ConnectionGraph2 = RakNetPINVOKE._RAKNET_SUPPORT_ConnectionGraph2_get();
  public static readonly int _RAKNET_SUPPORT_DirectoryDeltaTransfer = RakNetPINVOKE._RAKNET_SUPPORT_DirectoryDeltaTransfer_get();
  public static readonly int _RAKNET_SUPPORT_FileListTransfer = RakNetPINVOKE._RAKNET_SUPPORT_FileListTransfer_get();
  public static readonly int _RAKNET_SUPPORT_FullyConnectedMesh = RakNetPINVOKE._RAKNET_SUPPORT_FullyConnectedMesh_get();
  public static readonly int _RAKNET_SUPPORT_FullyConnectedMesh2 = RakNetPINVOKE._RAKNET_SUPPORT_FullyConnectedMesh2_get();
  public static readonly int _RAKNET_SUPPORT_MessageFilter = RakNetPINVOKE._RAKNET_SUPPORT_MessageFilter_get();
  public static readonly int _RAKNET_SUPPORT_NatPunchthroughClient = RakNetPINVOKE._RAKNET_SUPPORT_NatPunchthroughClient_get();
  public static readonly int _RAKNET_SUPPORT_NatPunchthroughServer = RakNetPINVOKE._RAKNET_SUPPORT_NatPunchthroughServer_get();
  public static readonly int _RAKNET_SUPPORT_NatTypeDetectionClient = RakNetPINVOKE._RAKNET_SUPPORT_NatTypeDetectionClient_get();
  public static readonly int _RAKNET_SUPPORT_NatTypeDetectionServer = RakNetPINVOKE._RAKNET_SUPPORT_NatTypeDetectionServer_get();
  public static readonly int _RAKNET_SUPPORT_PacketLogger = RakNetPINVOKE._RAKNET_SUPPORT_PacketLogger_get();
  public static readonly int _RAKNET_SUPPORT_ReadyEvent = RakNetPINVOKE._RAKNET_SUPPORT_ReadyEvent_get();
  public static readonly int _RAKNET_SUPPORT_ReplicaManager3 = RakNetPINVOKE._RAKNET_SUPPORT_ReplicaManager3_get();
  public static readonly int _RAKNET_SUPPORT_Router2 = RakNetPINVOKE._RAKNET_SUPPORT_Router2_get();
  public static readonly int _RAKNET_SUPPORT_RPC4Plugin = RakNetPINVOKE._RAKNET_SUPPORT_RPC4Plugin_get();
  public static readonly int _RAKNET_SUPPORT_TeamBalancer = RakNetPINVOKE._RAKNET_SUPPORT_TeamBalancer_get();
  public static readonly int _RAKNET_SUPPORT_TeamManager = RakNetPINVOKE._RAKNET_SUPPORT_TeamManager_get();
  public static readonly int _RAKNET_SUPPORT_UDPProxyClient = RakNetPINVOKE._RAKNET_SUPPORT_UDPProxyClient_get();
  public static readonly int _RAKNET_SUPPORT_UDPProxyCoordinator = RakNetPINVOKE._RAKNET_SUPPORT_UDPProxyCoordinator_get();
  public static readonly int _RAKNET_SUPPORT_UDPProxyServer = RakNetPINVOKE._RAKNET_SUPPORT_UDPProxyServer_get();
  public static readonly int _RAKNET_SUPPORT_ConsoleServer = RakNetPINVOKE._RAKNET_SUPPORT_ConsoleServer_get();
  public static readonly int _RAKNET_SUPPORT_RakNetTransport = RakNetPINVOKE._RAKNET_SUPPORT_RakNetTransport_get();
  public static readonly int _RAKNET_SUPPORT_TelnetTransport = RakNetPINVOKE._RAKNET_SUPPORT_TelnetTransport_get();
  public static readonly int _RAKNET_SUPPORT_TCPInterface = RakNetPINVOKE._RAKNET_SUPPORT_TCPInterface_get();
  public static readonly int _RAKNET_SUPPORT_LogCommandParser = RakNetPINVOKE._RAKNET_SUPPORT_LogCommandParser_get();
  public static readonly int _RAKNET_SUPPORT_RakNetCommandParser = RakNetPINVOKE._RAKNET_SUPPORT_RakNetCommandParser_get();
  public static readonly int _RAKNET_SUPPORT_EmailSender = RakNetPINVOKE._RAKNET_SUPPORT_EmailSender_get();
  public static readonly int _RAKNET_SUPPORT_HTTPConnection = RakNetPINVOKE._RAKNET_SUPPORT_HTTPConnection_get();
  public static readonly int _RAKNET_SUPPORT_HTTPConnection2 = RakNetPINVOKE._RAKNET_SUPPORT_HTTPConnection2_get();
  public static readonly int _RAKNET_SUPPORT_PacketizedTCP = RakNetPINVOKE._RAKNET_SUPPORT_PacketizedTCP_get();
  public static readonly int _RAKNET_SUPPORT_TwoWayAuthentication = RakNetPINVOKE._RAKNET_SUPPORT_TwoWayAuthentication_get();
  public static readonly int _RAKNET_SUPPORT_CloudClient = RakNetPINVOKE._RAKNET_SUPPORT_CloudClient_get();
  public static readonly int _RAKNET_SUPPORT_CloudServer = RakNetPINVOKE._RAKNET_SUPPORT_CloudServer_get();
  public static readonly int _RAKNET_SUPPORT_DynDNS = RakNetPINVOKE._RAKNET_SUPPORT_DynDNS_get();
  public static readonly int _RAKNET_SUPPORT_Rackspace = RakNetPINVOKE._RAKNET_SUPPORT_Rackspace_get();
  public static readonly int _RAKNET_SUPPORT_FileOperations = RakNetPINVOKE._RAKNET_SUPPORT_FileOperations_get();
  public static readonly int _RAKNET_SUPPORT_UDPForwarder = RakNetPINVOKE._RAKNET_SUPPORT_UDPForwarder_get();
  public static readonly int _RAKNET_SUPPORT_StatisticsHistory = RakNetPINVOKE._RAKNET_SUPPORT_StatisticsHistory_get();
  public static readonly int _RAKNET_SUPPORT_LibVoice = RakNetPINVOKE._RAKNET_SUPPORT_LibVoice_get();
  public static readonly int _RAKNET_SUPPORT_RelayPlugin = RakNetPINVOKE._RAKNET_SUPPORT_RelayPlugin_get();
  public static readonly string PRINTF_64_BIT_MODIFIER = RakNetPINVOKE.PRINTF_64_BIT_MODIFIER_get();
  public static readonly int NETWORK_ID_MANAGER_HASH_LENGTH = RakNetPINVOKE.NETWORK_ID_MANAGER_HASH_LENGTH_get();
  public static readonly int _TABLE_BPLUS_TREE_ORDER = RakNetPINVOKE._TABLE_BPLUS_TREE_ORDER_get();
  public static readonly int _TABLE_MAX_COLUMN_NAME_LENGTH = RakNetPINVOKE._TABLE_MAX_COLUMN_NAME_LENGTH_get();
  public static readonly int MESSAGE_FILTER_MAX_MESSAGE_ID = RakNetPINVOKE.MESSAGE_FILTER_MAX_MESSAGE_ID_get();
}

}
