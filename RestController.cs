using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BillingClientV3
{
    class RestController<T> 
    {
        private RestClient _client;
        private string _resource = "";
        private string _serverBase = ""; //= "http://10.0.0.13/damarnet/api/";
        private string _resourceSuffix = "";// = "/format/json";
        private string _json = "";

        //private T _row;
        //private List<T> _rows;
        private void InitClient()
        {
            _client = new RestClient();
        }
        public RestController()
        {
            //_row  = new T();
           // _rows = new List<T>();
            InitClient();
        }
        public RestController( string serverBase )
        {
            _serverBase = serverBase;
            InitClient();
            SetEndPoint();
        }
        public RestController(string serverBase, string resource )
        {
            _serverBase = serverBase;
            _resource = resource;
            InitClient();
            SetEndPoint();
        }
        public RestController(string serverBase, string resource, string resourceSuffix )
        {
            _serverBase = serverBase;
            _resource = resource;
            _resourceSuffix = resourceSuffix;
            InitClient();
            SetEndPoint();
        }
        public void SetServerBase(string serverBase)
        {
            _serverBase = serverBase;
            SetEndPoint();
        }
        public void SetResource( string Resource)
        {
            
            _resource = Resource;
            SetEndPoint();
        }
        public void SetResourceSuffix(string ResourceSuffix)
        {
            _resourceSuffix = ResourceSuffix;
            SetEndPoint();
        }
        private void SetEndPoint()
        { 
            _client.EndPoint = _serverBase + _resource + _resourceSuffix;
        }
        public T GetData()
        {
            _json =  _client.MakeRequest();
            return JsonConvert.DeserializeObject<T>(_json);
        }
    }
}
