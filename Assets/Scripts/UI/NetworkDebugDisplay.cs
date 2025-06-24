using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.Netcode;
using Unity.Netcode.Transports.UTP;
using UnityEngine;
using UnityEngine.UI;

public class NetworkDebugDisplay : MonoBehaviour
{
    [SerializeField] private Text portInfoText;
    [SerializeField] private Text ipInfoText;
    [SerializeField] private Text clientIdInfoText;

    private int portInfo;
    private string ipInfo;
    private string clientIdInfo;

    private UnityTransport.ConnectionAddressData Data;

    private void Update()
    {
        portInfo = Data.Port;
        ipInfo = Data.Address;

        portInfoText.text = portInfo.ToString();
        ipInfoText.text = ipInfo;
    }
}