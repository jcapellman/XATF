#pragma once

#include "XATF.h"

class model_object
{
	public:
		void init()
		{
			m_displayListID = glGenLists(1);

			glNewList(m_displayListID, GL_COMPILE);

			glColor3f(1.0, 0.0, 0.0);

			glRotatef(m_rotation, 0.0f, 1.0f, 0.0f);

			glBegin(GL_TRIANGLES);
				glVertex3f(0, 1, 0);
				glVertex3f(-1, -1, 0);
				glVertex3f(1, -1, 0);
			glEnd();

			glEndList();
		}

		void render()
		{			
			glCallList(m_displayListID);

			m_rotation += 0.015f;
		}

		~model_object()
		{
			glDeleteLists(m_displayListID, 1);
		}
	private:
		float m_rotation = 0.0f;

		GLuint m_displayListID = 0;
};
