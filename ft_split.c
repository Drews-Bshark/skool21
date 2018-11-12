int condition (char *str, char *charset)
{
        int i;
        int j;

        i = 0;
        while(str[i])
        {
                j = 0;
                if(str[i] == charset[j])
                {
                        while(charset[j++])
                        {
                                if(charset[j] != str[i + j])
                                        return (0);
                                if(charset[j + 1] == '\0')
                                        return (i + j);
                        }
                }
                j++;
        }
        return (0);
}


int count_str(char *str, char *charset)
{
	int i;
	int count;
	
	i = 0;
	count = 0;
	while(str[i])
	{	
		i = conditon (str[i], charset);
		if(i != 0)
			count++;
	}
	return (count);
}
int str_len (char *str)
{
	int i;

	i = 0;
	while(str[i])
		i++;
	return (i);
}

int str_copy (char *mas_str, char *charset, int count)
{
	int i;

	i = 0;
	while(chaset[i])
	{
		mas_str[count + i] = charset[i];
		i++;
	}
	return (count + j);
}


char **ft_split(char *str, char *charset)
{
	int i;
	char **mas_str;
	int j;
	int mas_point_one;
	int mas_point_two;

	mas_point_one = 0;
	j = 0;
	i = 0;
	mas_str = (char **)malloc(sizeof(char**) + count_st r(str, charset) + 1);
	while (str[i])
	{
		i = condition (str[i], charset);
		if(i !=0 )
		{
			mas_point_two = 0;
			mas_str[k] = (char *)malloc(sizeof (char) + (i + str_len(charset) + 1));
			mas_point_two = str_copy(mas_str, charset, mas_point_two);
			while(j < i)
			{
				mas_str[mas_point_one][mas_point_two] = str[j];
				j++;
				mas_point_two++;	
			}
			str_copy(mas_str, charset, mas_point_two);
			mas_point_one++;
		}
		i++;
	}
	mas_str[mas_point_one] = 0;
	return (mas_str);
}
