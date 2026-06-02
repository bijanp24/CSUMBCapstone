package TheaterDB;

import java.io.IOException;
import java.io.PrintWriter;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import javax.servlet.ServletException;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.HttpServlet;
import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

/**
 * Servlet implementation class Movie_Search
 */
@WebServlet("/View_Directors")
public class View_Directors_Servlet extends HttpServlet {
	private static final long serialVersionUID = 1L;
    
	static final String JDBC_DRIVER = "com.mysql.cj.jdbc.Driver";
	static final String DB_URL = "jdbc:mysql://localhost/mydb";
	// Database credentials
	static final String USER = "root";
	static final String PASS = "sesame80";

	String sql = "SELECT * FROM directors ORDER BY director_id";

	protected void doPost(HttpServletRequest request, HttpServletResponse response) throws ServletException, IOException {
		
		Connection conn = null;
		PreparedStatement pstmt = null;
		
		response.setContentType("text/html");
		PrintWriter out = response.getWriter();
		
		try {
			// Register JDBC driver
			Class.forName(JDBC_DRIVER);
			// Open a connection
			conn = DriverManager.getConnection(DB_URL, USER, PASS);
			// prepare sql select
			pstmt = conn.prepareStatement(sql);
			ResultSet rs = pstmt.executeQuery();
			
			out.println("<!DOCTYPE HTML><html><body>");
			out.println("<table><tr><th>director_id |</th><th>director_firstname |</th><th>director_lastname |</th><th>director_region</th></tr>");
			while (rs.next()) {
				out.println("<tr>");
				out.println("<td>"+rs.getInt("director_id")+"</td>");
				out.println("<td>"+rs.getString("director_firstname")+"</td>");
				out.println("<td>"+rs.getString("director_lastname")+"</td>");
				out.println("<td>"+rs.getString("director_region")+"</td>");
				out.println("</tr>");
			}
			rs.close();
			out.println("</table>");
			out.println("</body></html>");
			pstmt.close();
			//close connection
			conn.close();
			out.flush();
		} catch (Exception e) {
			//Handle errors
			e.printStackTrace();
		} // end try
		
	}

}
