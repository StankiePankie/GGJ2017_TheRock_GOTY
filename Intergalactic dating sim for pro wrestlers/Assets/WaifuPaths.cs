using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaifuPaths : MonoBehaviour {

    public struct path
    {
        public int[] m_path;
    }

    struct path_node
    {
        public int total_paths;
        public path[] m_paths;
    }


    public bool patrol;
    public Transform starting_point;
    public Transform[] points;
    private int destination;
    private int current_index;
    private int current_point;
    private UnityEngine.AI.NavMeshAgent agent;
    private path_node[] all_paths;
    public path current_path;

	// Use this for initialization
	void Start () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = starting_point.position;
        patrol = false;
        #region paths

        // 1-2, 1-28, 1-29
        all_paths[1].total_paths = 3;
        all_paths[1].m_paths[0].m_path[0] = 1;
        all_paths[1].m_paths[0].m_path[1] = 2;
        all_paths[1].m_paths[1].m_path[0] = 1;
        all_paths[1].m_paths[1].m_path[1] = 28;
        all_paths[1].m_paths[2].m_path[0] = 1;
        all_paths[1].m_paths[2].m_path[1] = 29;
        //2-1, 2-3-4-5, 2-6
        all_paths[2].total_paths = 3;
        all_paths[2].m_paths[0].m_path[0] = 2;
        all_paths[2].m_paths[0].m_path[1] = 3;
        all_paths[2].m_paths[0].m_path[2] = 4;
        all_paths[2].m_paths[0].m_path[3] = 5;
        all_paths[2].m_paths[1].m_path[0] = 2;
        all_paths[2].m_paths[1].m_path[0] = 1;
        all_paths[2].m_paths[2].m_path[1] = 2;
        all_paths[2].m_paths[2].m_path[1] = 6;
        //5-4-3-2
        all_paths[5].total_paths = 1;
        all_paths[5].m_paths[0].m_path[0] = 5;
        all_paths[5].m_paths[0].m_path[1] = 4;
        all_paths[5].m_paths[0].m_path[2] = 3;
        all_paths[5].m_paths[0].m_path[3] = 2;
        //6-2,6-7,6-8
        all_paths[6].total_paths = 3;
        all_paths[6].m_paths[0].m_path[0] = 6;
        all_paths[6].m_paths[0].m_path[1] = 2;
        all_paths[6].m_paths[1].m_path[0] = 6;
        all_paths[6].m_paths[1].m_path[1] = 7;
        all_paths[6].m_paths[2].m_path[0] = 6;
        all_paths[6].m_paths[2].m_path[1] = 8;
        //7-6,7-8
        all_paths[7].total_paths = 2;
        all_paths[7].m_paths[0].m_path[0] = 7;
        all_paths[7].m_paths[0].m_path[1] = 6;
        all_paths[7].m_paths[1].m_path[0] = 7;
        all_paths[7].m_paths[1].m_path[1] = 8;
        //8-7,8-6,8-9
        all_paths[8].total_paths = 3;
        all_paths[8].m_paths[0].m_path[0] = 8;
        all_paths[8].m_paths[0].m_path[1] = 7;
        all_paths[8].m_paths[1].m_path[0] = 8;
        all_paths[8].m_paths[1].m_path[1] = 6;
        all_paths[8].m_paths[2].m_path[0] = 8;
        all_paths[8].m_paths[2].m_path[1] = 9;
        //9-10-11-12-13,9-28,9-13
        all_paths[9].total_paths = 3;
        all_paths[9].m_paths[0].m_path[0] = 9;
        all_paths[9].m_paths[0].m_path[1] = 10;
        all_paths[9].m_paths[0].m_path[2] = 11;
        all_paths[9].m_paths[0].m_path[3] = 12;
        all_paths[9].m_paths[0].m_path[4] = 13;
        all_paths[9].m_paths[1].m_path[0] = 9;
        all_paths[9].m_paths[1].m_path[1] = 13;
        all_paths[9].m_paths[2].m_path[0] = 9;
        all_paths[9].m_paths[2].m_path[1] = 28;
        //13-12-11-10-9,13-14-15-16,13-23-22-21-20-19
        all_paths[13].total_paths = 3;
        all_paths[13].m_paths[0].m_path[0] = 13;
        all_paths[13].m_paths[0].m_path[1] = 12;
        all_paths[13].m_paths[0].m_path[2] = 11;
        all_paths[13].m_paths[0].m_path[3] = 10;
        all_paths[13].m_paths[0].m_path[4] = 9;
        all_paths[13].m_paths[1].m_path[0] = 13;
        all_paths[13].m_paths[1].m_path[1] = 14;
        all_paths[13].m_paths[1].m_path[2] = 15;
        all_paths[13].m_paths[1].m_path[3] = 16;
        all_paths[13].m_paths[2].m_path[0] = 13;
        all_paths[13].m_paths[2].m_path[1] = 23;
        all_paths[13].m_paths[2].m_path[2] = 22;
        all_paths[13].m_paths[2].m_path[3] = 21;
        all_paths[13].m_paths[2].m_path[4] = 20;
        all_paths[13].m_paths[2].m_path[5] = 19;
        //16-17-19,16-18-19
        all_paths[16].total_paths = 2;
        all_paths[16].m_paths[0].m_path[0] = 16;
        all_paths[16].m_paths[0].m_path[1] = 17;
        all_paths[16].m_paths[0].m_path[2] = 19;
        all_paths[16].m_paths[1].m_path[0] = 16;
        all_paths[16].m_paths[1].m_path[1] = 18;
        all_paths[16].m_paths[1].m_path[2] = 19;
        //19-27,19-24-25-26
        all_paths[19].total_paths = 2;
        all_paths[19].m_paths[0].m_path[0] = 19;
        all_paths[19].m_paths[0].m_path[1] = 27;
        all_paths[19].m_paths[1].m_path[0] = 19;
        all_paths[19].m_paths[1].m_path[1] = 24;
        all_paths[19].m_paths[1].m_path[2] = 25;
        all_paths[19].m_paths[1].m_path[3] = 26;
        //26-24-25-19
        all_paths[26].total_paths = 1;
        all_paths[26].m_paths[0].m_path[0] = 26;
        all_paths[26].m_paths[0].m_path[1] = 25;
        all_paths[26].m_paths[0].m_path[2] = 24;
        all_paths[26].m_paths[0].m_path[3] = 19;
        //27-28, 27-29
        all_paths[27].total_paths = 2;
        all_paths[27].m_paths[0].m_path[0] = 27;
        all_paths[27].m_paths[0].m_path[1] = 28;
        all_paths[27].m_paths[1].m_path[0] = 27;
        all_paths[27].m_paths[1].m_path[1] = 29;
        //28-1, 28-27
        all_paths[28].total_paths = 2;
        all_paths[28].m_paths[0].m_path[0] = 28;
        all_paths[28].m_paths[0].m_path[1] = 1;
        all_paths[28].m_paths[1].m_path[0] = 28;
        all_paths[28].m_paths[1].m_path[1] = 27;
        //29-30, 29-1
        all_paths[29].total_paths = 2;
        all_paths[29].m_paths[0].m_path[0] = 29;
        all_paths[29].m_paths[0].m_path[1] = 30;
        all_paths[29].m_paths[1].m_path[0] = 29;
        all_paths[29].m_paths[1].m_path[1] = 1;
        //30-29
        all_paths[30].total_paths = 1;
        all_paths[30].m_paths[0].m_path[0] = 30;
        all_paths[30].m_paths[0].m_path[1] = 29;       
        #endregion
        current_path = all_paths[1].m_paths[0];
        destination = current_path.m_path[1];
        current_index = 1;
	}

    void NextPointInPath()
    {
        if(current_path.m_path[current_index] == destination)
        {
            current_path = NextPath(destination);
            current_index = 0;
            agent.destination = points[current_path.m_path[current_index]].position;

        }
        else
        {
            current_index++;
            agent.destination = points[current_path.m_path[current_index]].position;
        }
    }
	
    path NextPath(int index)
    {

        int seed = (int)Random.Range(0,1000);
        int random_path = seed%all_paths[index].total_paths;
        destination = all_paths[index].m_paths[random_path].m_path[all_paths[index].m_paths[random_path].m_path.GetLength(0)];
        return all_paths[index].m_paths[random_path];

    }

    void RandomPoint()
    {
        int random = (int)Random.Range(0, 30);
        agent.destination = points[random].position;
    }
	// Update is called once per frame
	void Update () {


        if (agent.remainingDistance < 0.5f)
        {
         //   NextPointInPath();
            if(patrol==true)
            RandomPoint();
        }
	}
}
