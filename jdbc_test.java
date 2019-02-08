package jdbc_test;

import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;

public class jdbc_test {
	public static void main(String[] args) {
		
		String csv = "C:\\Users\\All\\Desktop\\����ö �뼱.csv";
		String line = "";
		String csvSplitBy = ",";
		
		Connection con = null;
		Statement st = null;
		ResultSet rs = null;
		int res = 0;
		
		String url = "jdbc:postgresql://localhost:5432/testdb";
		String user = "postgres";
		String password = "postgres";
		ArrayList<String> transferList = new ArrayList<>();
		ArrayList<node> nodeList = new ArrayList<>();
		
		try {
			con = DriverManager.getConnection(url, user, password);
			st = con.createStatement();
			String preID = "";
			String source = "";
			String target = "";
			double preCost = 0;
			int count = 0;
			//PostgreSQL�� ����
			
			try (BufferedReader br = new BufferedReader(new FileReader(csv))){
				//csv������ �о� ����
				while ((line = br.readLine()) != null) {
					String[] subway = line.split(csvSplitBy);
					String transfer = "";
					if (subway[5].equals("T") == true) 
						transfer = subway[5];
					//ȯ�¿� ���� �����Ͱ� ���� �� ���� �ְ� ������ ��
					String insertSQL = "INSERT INTO m_node " + "VALUES (" + subway[0] + ",'" + subway[1] + "','" + subway[3] + "','" + subway[4] + "','" + transfer + "','" + subway[6] + "')";
					System.out.println(insertSQL);
					res = st.executeUpdate(insertSQL);

					//"delete from m_node where gid in (select n.gid from m_node as n,(select statnnm, count(statnnm) from m_node where linenum = '1' group by statnnm having count(statnnm) = 2) as d where n.statnnm = d.statnnm limit 1)"

					target = subway[0];
					double cost = 0;
		
					if (source.equals("") == false) 
						//m_network�� ù�� �ִ� ���� ����
					{
						if (target.equals("194") == true )
							System.out.println("");
						cost = Double.parseDouble(subway[2]) - preCost;
						if (Double.parseDouble(subway[2]) == 0){
							preID = subway[1];
							source = subway[0];
							preCost = Double.parseDouble(subway[2]);
							continue;
						}
						//���ο� �뼱���� ����ÿ� cost�� 0�� �ǹǷ� �� ���� �ѱ�
						insertSQL = "INSERT INTO m_network " + "VALUES (" + count + ",'" + preID + "_" + subway[1] + "'," + source + "," + subway[0] + "," + String.format("%.1f", cost) + ",'" + subway[4] + "')";
						//INSERT count = gid(������� ��ȣ ����), preID_subway[1] = id(���� �� ��ȣ�� ���� �� ��ȣ�� �����Ͽ� id����), cost�� �Ҽ��� ���ڸ�����
						res = st.executeUpdate(insertSQL);
						System.out.println(insertSQL);
					}
					preID = subway[1];
					source = subway[0];
					preCost = Double.parseDouble(subway[2]);
					count++;
				}
				
				String insertSQL = "DELETE FROM m_node a WHERE ctid > (SELECT MIN(ctid) FROM m_node b WHERE b.gid = a.gid)";
				res = st.executeUpdate(insertSQL);

				rs = st.executeQuery("select statnnm FROM m_node where transfer = 'T' group by statnnm order by statnnm");
				String tmp = "";
				while (rs.next()) {
					if (tmp.equals(rs.getString(1)) == false)
						transferList.add(rs.getString(1));
					System.out.println(rs.getString(1));

					tmp = rs.getString(1);
				}

				for (int i = 0; i < transferList.size(); i++) {
					//ȯ�¿��� ���� �迭����Ʈ�� �����ŭ ����
					rs = st.executeQuery("select * FROM m_node where statnnm = '" + transferList.get(i) + "' and transfer = 'T'");
					int cnt = 0;

					while (rs.next()) {
						node n = new node(Integer.parseInt(rs.getString(1)) , rs.getString(2), rs.getString(3), rs.getString(4), rs.getString(5));
						nodeList.add(n);
						//nodeŬ������ ����� �����ڸ� �ҷ��� ����
						System.out.println(rs.getString(1) + "," + rs.getString(2) + "," + rs.getString(3) + "," + rs.getString(4) + "," + rs.getString(5));
						cnt++;
					}
					for (int j = 0; j < nodeList.size(); j++) {
						for (int k = j+1; k < nodeList.size(); k++) {
							//ȯ�¿� ��峢�� ��� ������Ѿ��ϹǷ� for���� �ι�
							String insertSQL2 = "INSERT INTO m_network " + "VALUES (" + count + ",'" + nodeList.get(j).getId() + "_" + nodeList.get(k).getId() + "'," + nodeList.get(j).getGid() + "," + nodeList.get(k).getGid() + "," + 7 + ",'T')";
							res = st.executeUpdate(insertSQL2);
							System.out.println(insertSQL2);
							count++;
						}
					}
					nodeList.clear();
				}

			}
		} catch (IOException e) {
			e.printStackTrace();
		} catch (SQLException ex) {
			System.out.println(ex);
		}
		
//		Connection con = null;
//		Statement st = null;
//		ResultSet rs = null;
//		
//		String url = "jdbc:postgresql://localhost:5432/testdb";
//		String user = "postgres";
//		String password = "postgres";
//		
//		
//		try {
//			con = DriverManager.getConnection(url, user, password);
//			st = con.createStatement();
//			//rs = st.executeUpdate("INSERT INTO network " + "VALUES (" + );
//			rs = st.executeQuery("SELECT * FROM r_network");
//			String tmp = "";
//			while (rs.next()) {
//				if (tmp.equals(rs.getString(1)) == false)
//				//System.out.println(rs.getString(1) + "\t" +  rs.getString(2));
//				
//				tmp = rs.getString(1);
//			}
//		} catch (SQLException ex) {
//				System.out.println(ex);
//		}
	}
}

