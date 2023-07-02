using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Newtonsoft.Json;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Numerics;
using System.Security.Cryptography;
using FireSharp;
using System.Runtime.Intrinsics.X86;


namespace dieforproject
{
    internal class room
    {

        int id = 0;
        int port = 0;
        List<Socket> clients = new List<Socket>();
        IPEndPoint RoomServerIP;
        Socket server_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Thread server_run;
        NetworkStream ns;
        Random r = new Random();
        Dictionary<string, question> ques = new Dictionary<string, question>();
        List<string> used = new List<string>();
        
        public room(int id, int port) {
            this.id = id;
            this.port = port;
            RoomServerIP = new IPEndPoint(IPAddress.Any, port);
            xx = new FireSharp.FirebaseClient(config);
            server_run = new Thread(Start);
            server_run.Start();
        }

        IFirebaseConfig config = new FirebaseConfig()
        {
            AuthSecret = "vTd2kobcxCaAw3EbOOqfRQmWxdyiD6JkB80yr5t2",
            BasePath = "https://fillmao-4e9e1-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient xx;

        void send(Socket client, string msg)
        {
            byte[] send_data = System.Text.Encoding.UTF8.GetBytes(msg);
            ns = new NetworkStream(client);
      
            ns.Write(send_data, 0, send_data.Length);
            ns.Flush();
        }

        void room_create(roomdetail room_Recv, Socket client)
        {
            string idphong = r.Next(100000, 999999).ToString();
            Console.WriteLine(idphong);
            room_Recv.RoomId = idphong;
            var ssetter = xx.Set("room/" + idphong, room_Recv);
            for (int i = 0; i < room_Recv.PlayerList.Count; i++)
            {
                room_Recv.PlayerList[i].RoomId = room_Recv.RoomId;
                xx.Update("player/" + room_Recv.PlayerList[i].PlayerId, room_Recv.PlayerList[i]);
            }
            send(client, idphong);
        }

        void Create_Process(Socket client, string[] response_Recv)
        {
            roomdetail room_Recv;
            room_Recv = JsonConvert.DeserializeObject<roomdetail>(response_Recv[1]);
            room_create(room_Recv, client);
        }

        void Join_Process(Socket client, string[] response_Recv)
        {
            FirebaseResponse res = xx.Get("room/" + response_Recv[1]);
            roomdetail response = res.ResultAs<roomdetail>();
            if (response.PlayerList.Count < response.NumberOfPlayer)
            {
                Player player_info;
                player_info = JsonConvert.DeserializeObject<Player>(response_Recv[2]);
                player_info.RoomId = response_Recv[1]; 
                var updater_player = xx.Update("player/" + player_info.PlayerId, player_info);
                response.PlayerList.Add(player_info);
                var updater_room = xx.Update("room/" + response_Recv[1], response);

                string roominfo = JsonConvert.SerializeObject(response);
                foreach (Socket c in clients)
                {
                    send(c, roominfo);
                }
            }
            else
            {
                send(client, "full");
            }
        }

        void Login_Process(Socket client, string[] response_Recv)
        {
            Player player_Info;
            player_Info = JsonConvert.DeserializeObject<Player>(response_Recv[1]);
            string idngchoi = r.Next(100000, 999999).ToString();
            Console.WriteLine(idngchoi);
            Player player = new Player(
                idngchoi,
                player_Info.PlayerName

            );
            var ssetter = xx.Set("player/" + idngchoi, player);
            send(client, idngchoi);
        }

        void Leave_Process(Socket client, string[] response_Recv)
        {
            FirebaseResponse res = xx.Get("room/" + response_Recv[1]);
            roomdetail response = res.ResultAs<roomdetail>();
            Player player_info;
            player_info = JsonConvert.DeserializeObject<Player>(response_Recv[2]);

            for (int i = 0; i < response.PlayerList.Count; i++)
            {
                if (response.PlayerList[i].PlayerId == player_info.PlayerId)
                {
                    response.PlayerList.RemoveAt(i);
                    break;
                }
            }
            var updater = xx.Update("room/" + response_Recv[1], response);
            Console.WriteLine(response.PlayerList.Count);
            string roominfo = JsonConvert.SerializeObject(response);

            foreach (Socket c in clients)
            {
                send(c, roominfo);
            }
        }

        void Ready_Process(Socket client, string[] response_Recv)
        {
            Player player_info;
            player_info = JsonConvert.DeserializeObject<Player>(response_Recv[1]);
            Console.WriteLine(player_info.IsReady);
            string room_id = player_info.RoomId;
            FirebaseResponse res = xx.Get("room/" + room_id);
            roomdetail response = res.ResultAs<roomdetail>();
            for (int i = 0; i < response.PlayerList.Count; i++)
            {
                if (response.PlayerList[i].PlayerId == player_info.PlayerId)
                {
                    response.PlayerList[i].IsReady = player_info.IsReady;
                }
            }

            var updater = xx.Update("room/" + response.RoomId, response);

            string roominfo = JsonConvert.SerializeObject(response);

            foreach (Socket c in clients)
            {
                send(c, roominfo);
            }
        }
        void answer(Socket client, string[] response_Recv)
        {
            FirebaseResponse res = xx.Get("Answer");
            Dictionary<string, answer> ans = new Dictionary<string, answer>();
            ans = res.ResultAs<Dictionary<string, answer>>();
            //List<string> key_used = new List<string>();
            Console.WriteLine(clients.Count);
            foreach (Socket c in clients)
            {
                List<answer> answers = new List<answer>();
                for (int i = 0; i < 4; i++)
                {
                    List<string> keyList = new List<string>(ans.Keys);
                    int keyList_len = keyList.Count();
                    while (true)
                    {
                        keyList_len = keyList.Count();
                        int x = r.Next(0, keyList_len);
                        string randomKey = keyList[x];
                        if (!answers.Contains(ans[randomKey])) 
                        {
                            if (ans[randomKey].Idch == response_Recv[1].Trim())
                            {
                                Console.WriteLine(ans[randomKey].Cautl);
                                answers.Add(ans[randomKey]);
                                ans.Remove(randomKey);
                                keyList.RemoveAt(x);
                                break;
                            }
                            else
                            {
                                ans.Remove(randomKey);
                                keyList.Remove(randomKey);
                            }
                        }
                        
                    }

                }
                string _answer = JsonConvert.SerializeObject(answers);
                Console.WriteLine(_answer);
                send(c, _answer);
            }
            
        }
        Dictionary<string, string> kq = new Dictionary<string, string>();
        string return_answer = "";
        Object queue = new Object();
        void answer_selection(string[] response_Recv)
        {
            /*Player player_info;
            player_info = JsonConvert.DeserializeObject<Player>(response_Recv);
            string room_id = player_info.RoomId;
            FirebaseResponse res = xx.Get("room/" + room_id);
            roomdetail response = res.ResultAs<roomdetail>();
            for (int i = 0; i < response.PlayerList.Count; i++)
            {
                if (response.PlayerList[i].PlayerId == player_info.PlayerId)
                {
                    response.PlayerList[i].IsReady = player_info.IsReady;
                }
            }

            var updater = xx.Update("room/" + response.RoomId, response);
            int cnt = 0;
            for(int i = 0; i < response.NumberOfPlayer; i++)
            {
                if (response.PlayerList[i].Answer != "")
                {
                    cnt++;
                }
            }
            if(cnt == response.NumberOfPlayer)
            {

            }*/
            FirebaseResponse res = xx.Get("room/" + response_Recv[3]);
            roomdetail response = res.ResultAs<roomdetail>();
            
            lock (queue) {
                kq.Add(response_Recv[2], response_Recv[1]);
                return_answer += response_Recv[2] + ", ";
            }
        }
        Dictionary<string, int> vote_kq = new Dictionary<string, int>();
        int cnt = 0;
        void recv_vote(string[] response_Recv)
        {
            
                if (vote_kq.ContainsKey(response_Recv[1]))
                {
                    vote_kq[response_Recv[1]]++;
                }
                else
                {
                    vote_kq.Add(response_Recv[1], 1);
                }
                cnt++;
                if (cnt == kq.Count)
                {
                    string answer_highest_voting = vote_kq.Keys.Max();
                    Console.WriteLine(answer_highest_voting);
                    string idplayer = kq[answer_highest_voting];
                    Console.WriteLine(idplayer);

                    FirebaseResponse res = xx.Get("player/" + idplayer);
                    Player response = res.ResultAs<Player>();

                    res = xx.Get("room/" + response.RoomId);
                    roomdetail room_recv = res.ResultAs<roomdetail>();
                    for (int i = 0; i < room_recv.NumberOfPlayer; i++)
                    {
                        if (room_recv.PlayerList[i].PlayerId == response.PlayerId)
                        {
                            Console.WriteLine(room_recv.PlayerList[i].PlayerName);
                            room_recv.PlayerList[i].Point += 100;

                            Console.WriteLine(room_recv.PlayerList[i].Point);
                        }
                    }
                    var updater = xx.Update("room/" + response.RoomId, room_recv);
                    foreach (Socket c in clients)
                    {
                        send(c, "done");
                    }
                    kq.Clear();
                    cnt = 0;
                    vote_kq.Clear();
                }
            
        }
        void ans_sent()
        {
            foreach (Socket c in clients)
            {
                send(c, return_answer);
            }
            return_answer = "";
                //kq.Clear();
            
        }
        void endgame(string[] response_Recv)
        {
            FirebaseResponse res = xx.Get("room/" + response_Recv[1]);
            roomdetail response = res.ResultAs<roomdetail>();

            string roominfo = JsonConvert.SerializeObject(response);
            foreach(Socket c in clients)
            {
                send(c, roominfo);
            }

        }
        void receive_and_broacast(object obj)
        {
            Socket client = (Socket)obj;
            string[] question;
            try
            {

                while (true){


                    string msg = "";
                    do
                    {
                        byte[] recvd = new byte[1024];
                        client.Receive(recvd);
                        msg += Encoding.UTF8.GetString(recvd);
                    }while (msg[msg.Length-1] != '\0' && msg[msg.Length-1] != '\n');
                    

                    
                    if (msg != null && msg[0] != '\0')
                    {
                        Console.WriteLine(msg);
                        string[] response_Recv = msg.Split(", ");
                        string option = response_Recv[0];
                        Console.WriteLine(response_Recv[1]);
                        if (option == "login")  // mỗi option đã có hàm Process tương ứng
                        {
                            
                            Thread login = new Thread(() => Login_Process(client, response_Recv));
                            login.Start();

                        }
                        else if (option == "create_room")
                        {
                            

                            Thread create = new Thread(() => Create_Process(client, response_Recv));
                            create.Start();
                        }
                        else if (option == "join_room")
                        {
                            

                            Thread join = new Thread(() => Join_Process(client, response_Recv));
                            join.Start();


                        }
                        else if (option == "leave_room")
                        {
                           

                            Thread leave = new Thread(() => Leave_Process(client, response_Recv));
                            leave.Start();
                        }
                        else if (option == "ready")
                        {
                            
                            Thread ready = new Thread(() => Ready_Process(client, response_Recv));
                            ready.Start();
                        }
                        else if(option == "get_question")
                        {
                            List<string> keyList = new List<string>(ques.Keys);
                            //Console.WriteLine(keyList.Count);
                            
                            while (true)
                            {
                                string randomKey = keyList[r.Next(keyList.Count)];
                                if (!used.Contains(randomKey))
                                {
                                    used.Add(randomKey);
                                    
                                    foreach (Socket c in clients)
                                    {
                                        string question_info = JsonConvert.SerializeObject(ques[randomKey]);
                                        
                                        send(c, question_info);
                                    }
                                    break;

                                }
                            }
                        }
                        else if(option == "get_answer")
                        {

                            Thread get_answer = new Thread(() => answer(client, response_Recv));
                            //get_answer.IsBackground = true;
                            get_answer.Start();

                        }
                        else if( option == "answer_selected")
                        {
                            Thread answer_selected = new Thread(() => answer_selection(response_Recv));
                            answer_selected.Start();
                        }
                        
                        else if(option == "voting")
                        {
                            Thread voted = new Thread(() => recv_vote(response_Recv));
                            voted.Start();
                        }
                        else if(option == "endgame")
                        {
                            Thread end = new Thread(() => endgame(response_Recv));
                            end.Start();
                        }
                        else if (option == "recv_ans")
                        {
                            Thread xxx = new Thread(ans_sent);
                            xxx.Start();
                        }
                    }
                    else if ((client.Poll(-1, SelectMode.SelectRead)) || (client.Available != 0))
                    {
                        Console.WriteLine("LOLOLOLOLOLO");
                        clients.Remove(client);
                        
                        client.Close();
                        if (clients.Count == 0)
                        {
                            Console.WriteLine("bo m dong server");
                            server_socket.Close();
                        }
                        break;

                    }
                    else
                    {
                        clients.Remove(client);
                        Console.WriteLine("1 thz out");
                        client.Close();
                        if (clients.Count == 0)
                        {
                            Console.WriteLine("bo m dong server");
                            server_socket.Close();
                        }
                        break;
                    }
                    
                }
            }
            catch
            {
                Console.WriteLine("1 thz ou   t");
                clients.Remove(client);
                client.Close();
                if (clients.Count == 0)
                {
                    Console.WriteLine("bo m dong server");
                    server_socket.Close();
                }
            }
        }
        
        public void Start()
        {
            server_socket.Bind(RoomServerIP);
            Thread listen = new Thread(() =>
            {
                try
                {
                    FirebaseResponse res = xx.Get("question");
                    ques = res.ResultAs<Dictionary<string, question>>();
                    while (true)
                    {
                        Console.WriteLine("hello i'm in");
                        server_socket.Listen(-1);
                        Socket client = server_socket.Accept();
                        clients.Add(client);

                        Thread receive = new Thread(receive_and_broacast);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    RoomServerIP = new IPEndPoint(IPAddress.Any , port);
                    Socket server_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            //listen.IsBackground = true;
            listen.Start();
        }

    }


}
