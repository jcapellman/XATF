#pragma once

#include "XATF.h"

class model_object
{
	public:
		void Render()
		{
			glRotatef(m_rotation, 0.0f, 1.0f, 0.0f);

			glColor3f(1.0, 0.0, 0.0);

			glBegin(GL_TRIANGLES);
				glVertex3f(0, 1, 0);
				glVertex3f(-1, -1, 0);
				glVertex3f(1, -1, 0);
			glEnd();

			m_rotation += 0.015f;
		}
	private:
		float m_rotation = 0.0f;
};
