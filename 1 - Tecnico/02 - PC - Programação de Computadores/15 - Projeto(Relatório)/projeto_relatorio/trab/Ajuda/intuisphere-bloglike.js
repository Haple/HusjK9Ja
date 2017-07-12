
function IS_blogslike_getXmlNodeValue(name,parent)
{
	var obj = parent.getElementsByTagName(name)
	if (obj && obj.length>0)
	{
		if (obj[0].firstChild)
		{
			return obj[0].firstChild.nodeValue
		}
	}
	return "";
}


function IS_blogslike_getXmlAttributeValue(parent,name)
{
	var obj = parent.getElementsByTagName(name)
	if (obj && obj.length>0)
	{
		var node = obj[0]
		return node.getAttribute('val');
		
	}
	return "";
}

//////////////

function IS_blogslike_onLoad(id)
{
	if (!document.is_bloglike_object.timer)
	{
		document.is_bloglike_object.timer = setTimeout("IS_blogslike_centerCurrentWidget()",500);
		
		
	}
	if (document.is_global_object.is_preview==false)
	{
		IS_blogslike_refreshCountersComments([id]);
	}
}

function IS_blogslike_centerCurrentWidget()
{
	if (document.is_bloglike_object.opened_widget)
	internal_IS_blogslike_centerWidget(document.is_bloglike_object.opened_widget);
	document.is_bloglike_object.timer = setTimeout("IS_blogslike_centerCurrentWidget()",500);
}

function internal_IS_blogslike_centerWidget(widget)
{
	var width = getWindowWidth() ;
	var height = getWindowHeight() ;		
	
	var left = getWindowScrollX()+(width - widget.clientWidth)/2;
	var top = getWindowScrollY()+(height - widget.clientHeight)/2;
	moveElement(widget,left,top);	
	moveElement(widget,left,top);
}

function IS_blogslike_addComment(id_article,key_site,colBg,colText)
{
	
	var form = getElementByKey("layer_blogs_post_form");
	var st = form.style
	if (colBg.length>0)
	{
		st.backgroundColor="#"+colBg
	}
	if (colText.length>0)
	{
		st.color="#"+colText	
	}
	IS_blogslike_displayInputCommentForm(true);
	document.is_form_blogslike_post.reset();
	document.is_form_blogslike_post.id_article.value=id_article
	document.is_form_blogslike_post.key_site.value=key_site
	//
}


function IS_blogslike_displayInputCommentForm(b)
{

	if (document.is_bloglike_object.opened_widget)
	{
		displayElement(document.is_bloglike_object.opened_widget,false)	
		document.is_bloglike_object.opened_widget.style.display="none";
		document.is_bloglike_object.opened_widget= null;
	}
	if (b)
	{
		document.is_bloglike_object.opened_widget = getElementByKey("layer_blogs_post_form");
		displayElement(document.is_bloglike_object.opened_widget,true)	
		document.is_bloglike_object.opened_widget.style.display="block";
		internal_IS_blogslike_centerWidget(document.is_bloglike_object.opened_widget);
	}
}

function IS_blogslike_displayInputCommentsList(b)
{
	
	if (document.is_bloglike_object.opened_widget)
	{
		document.is_bloglike_object.opened_widget.style.display="none";
		displayElement(document.is_bloglike_object.opened_widget,false)	
		document.is_bloglike_object.opened_widget= null;
	}	
	if (b)
	{
		document.is_bloglike_object.opened_widget = getElementByKey("layer_blogs_comments");
		displayElement(document.is_bloglike_object.opened_widget,true);
			document.is_bloglike_object.opened_widget.style.display="block";
		internal_IS_blogslike_centerWidget(document.is_bloglike_object.opened_widget);
	}	
}

function IS_blogslike_canceltCommentsList()
{
	IS_blogslike_displayInputCommentsList(false)
}

function IS_blogslike_change_comments_counts(id_article,nb)
{
	var o = getElementByKey("layer_blogs_comments_count_"+id_article);
	IS_writeLayer(o,nb);	
}


function IS_blogslike_displayComments(id,colBg,colText)
{
	var form = getElementByKey("layer_blogs_comments");
	var st = form.style
	if (colBg.length>0)
	{
		st.backgroundColor="#"+colBg
	}
	if (colText.length>0)
	{
		st.color="#"+colText	
	}
	
	IS_blogslike_displayInputCommentsList(true);
	var o = getElementByKey("layer_blogs_comments_content");
		
	IS_writeLayer(o,"<div align=center>"+document.is_bloglike_object.messages.loading_progress+"</div>");	
	
	var data ="list_id="+id;
	
	if (document.is_global_object.is_preview)
	{
		var o = getElementByKey("layer_blogs_comments_content");
		var mess= document.is_global_object.messages.not_allowed_in_preview_mode;
		IS_writeLayer(o,mess);			
		
		return;
	}	
	IS_postServerData("cariblog.php?action=get_comments",data,slot_IS_blogslike_displayComments);
}


function slot_IS_blogslike_displayComments(context)
{
	var is_request = context;
	if (is_request.success)
	{
	
		var doc = is_request.rootDocumentElement//.req.responseXML.documentElement2
	
		var text="";
		var items = doc.getElementsByTagName("OBJECT");
		for (i=0;i<items.length;i++)
		{
			var obj_comment = items[i]
					
			var id_article=IS_blogslike_getXmlAttributeValue(obj_comment,"id_article")
			var comment=IS_blogslike_getXmlAttributeValue(obj_comment,"comment")
			
			var author=IS_blogslike_getXmlAttributeValue(obj_comment,"author")
			var created=IS_blogslike_getXmlAttributeValue(obj_comment,"created")
			var email=IS_blogslike_getXmlAttributeValue(obj_comment,"email")
			
			comment = encodeToHtml(comment);
			comment = replaceSubstring(comment,"/br/","<br>",true);
			
			author = encodeToHtml(author);
			email = encodeToHtml(email);
			
			
			if (email=="http://")
			{
				email="";
			}
			
			var footer_mess = document.is_bloglike_object.messages.footer_comment;
			footer_mess = replaceSubstring(footer_mess,"$(author)",author);
			footer_mess = replaceSubstring(footer_mess,"$(date)",created);
			
			if (email.length>0)
			{
				var label_url="Url";
				var url = email;
				if ((email.indexOf("@")>0)&&(email.indexOf("mailto:")<0))
				{
					url="mailto:"+email;
					label_url="Email";
				}
				//email="| <a href='"+url+"' target=_blank>"+email+"</a>";
				email="| <a href='"+url+"' target=_blank>"+label_url+"</a>";
			}
			footer_mess = replaceSubstring(footer_mess,"$(url)",email);
			
			///
			//text+="<div class=intuisphere-bloglike-comment-border>";
			
			text+="<div class=intuisphere-bloglike-comment-text>"+comment+"</div>";
			text+="<span class='intuisphere-bloglike-small-readonlytext'>"+footer_mess+"</span>"	
			//text+="</div>";
			text+="<hr>";
			
			//text+="<br>";	
			//text+="<br>";	
				
		}	
		
		var o = getElementByKey("layer_blogs_comments_content");
		IS_writeLayer(o,text);
	}
	else
	{
		var o = getElementByKey("layer_blogs_comments_content");
		var mess= is_request.error_msg;
		if (document.is_global_object.is_preview)
		{
			mess = document.is_global_object.messages.not_allowed_in_preview_mode;
		}

		IS_writeLayer(o,mess);		
	}	
}




function IS_blogslike_cancelComment()
{
	IS_blogslike_displayInputCommentForm(false);
}


function IS_blogslike_refreshCountersComments(array_id_article)
{
	if (document.is_global_object.is_preview)
	{
		return;
	}	
	
	
	var list_id="";
	
	for (i=0;i<array_id_article.length;i++)
	{
		if (i>0)list_id+=","
		list_id+=array_id_article[i]
	}
	var data ="";
	data+="list_id="+list_id;
	IS_postServerData("cariblog.php?action=refresh_counter_comments",data,slot_IS_blogslike_refreshCountersComments,array_id_article);	
}

function slot_IS_blogslike_refreshCountersComments(context,optional_args)
{
	var array_id_article = optional_args;
	for (var i=0;i<array_id_article.length;i++)
	{
		var id_counter=array_id_article[i]
		var s = "?";
		if (context.success)
		{
			var doc = context.rootDocumentElement//.req.responseXML.documentElement2
			var items = doc.getElementsByTagName("counter_"+id_counter);
	        	if (items.length>0)
	        	{
	        		s = trimString(items[0].firstChild.nodeValue)
	        	}			
		}
		else
		{
			s = "?";
		}		

        	
        	IS_blogslike_change_comments_counts(id_counter,s)
	}	
		
}

function IS_onSubmailBlogslikeComment()
{
	if (document.is_bloglike_object.article_submited)
	{
		alert(document.is_global_object.messages.please_wait);
		return;
	}
	var form = getElementByKey("is_form_blogslike_post");
	

	var email_value = form.email.value;
	if (email_value=="http://")
	{
		email_value="";
	}
	
	var comment_value = trimString(form.comments.value);

	comment_value = replaceSubstring(comment_value,"\r\n","<br>",true);
	comment_value = replaceSubstring(comment_value,"\n","<br>",true);
	comment_value = replaceSubstring(comment_value,"+","%u2b",true);

	if (comment_value.length==0)
	{
		alert(document.is_bloglike_object.messages.error_comment_not_filled);
		return;
	}
	
	var author = trimString(form.author_article.value);
	author = replaceSubstring(author,"+","%u2b",true);
	if (author.length==0)
	{
		alert(document.is_bloglike_object.messages.error_author_not_filled);
		return;
	}	

	var data ="";
	data+="email="+escape(email_value);
	data+="&id_article="+escape(form.id_article.value);
	data+="&comments="+escape(comment_value);
	data+="&author="+escape(author);
	data+="&key_site="+escape(form.key_site.value);

	if (document.is_global_object.is_preview)
	{
		alert(document.is_global_object.messages.not_allowed_in_preview_mode)
		return;
	}
	document.is_bloglike_object.article_submited=true;
	IS_postServerData("cariblog.php?action=post_comment",data,slot_IS_onSubmailBlogslikeComment,form.id_article.value);

}

function slot_IS_onSubmailBlogslikeComment(context,optional_args)
{
	document.is_bloglike_object.article_submited=false;
	if (context.success)
	{
		var id_article = optional_args;
		IS_blogslike_displayInputCommentForm(false);
		var o = getElementByKey("layer_blogs_comments_count_"+id_article);
		var current_val = trimString(IS_innerLayer(o));
		var current_nb = 0;
		try
		{
			current_nb=eval(current_val);
		}
		catch (e)
		{
			current_nb=0;
		}
		IS_blogslike_change_comments_counts(id_article,current_nb+1)
	}
	else
	{
		alert(context.error_msg)
	}	
}

///////////////////////////////////////////////////////////////


document.IS_array_XmlRequest = new Array();


function IS_XmlRequest()
{
	if (window.XMLHttpRequest) 
	{
		this.req = new XMLHttpRequest();
	}
	else
	if (window.ActiveXObject) 
	{
		this.req = new ActiveXObject("Microsoft.XMLHTTP");
		//req = new ActiveXObject("Msxml2.XMLHTTP");
	}	
}


IS_XmlRequest.prototype.send=function (url,s_data,func_slot,optional_args)
{
	this.is_valid = true;
	this.slot_finalize = func_slot;
	this.optional_args = optional_args;
	var async =true;
        this.success=false;
        if (async)
        {
        	document.IS_array_XmlRequest[document.IS_array_XmlRequest.length]=this;
        	this.req.onreadystatechange = IS_XmlRequest_generic_processReqChange;
        }
        this.req.open("POST", url, async);
     
      	this.req.setRequestHeader("Expires", "Mon, 26 Jul 1997 05:00:00 GMT")
      	this.req.setRequestHeader("Cache-Control", "no-store, no-cache, must-revalidate, post-check=0, pre-check=0")
      	this.req.setRequestHeader("Pragma", "no-cache")
      	this.req.setRequestHeader("Content-Type","application/x-www-form-urlencoded");
	
	
        this.req.send(s_data);
        
        if (async==false)
        {
         	IS_XmlRequest_processReqChange(this);
        }        
}

function IS_XmlRequest_processReqChange(object_context)
{
	if (object_context.req.status == 200) 
	{
		
		//
		//alert( MsxmlVersion() )
		var doc_parsed = false;
		var doc_loaded = false;
		var doc;
	
		if ((object_context.req.responseXML!=null)&&(object_context.req.responseXML.documentElement!=null))
		{
	        	var tmp_doc = object_context.req.responseXML.documentElement
	        	var items = tmp_doc.getElementsByTagName("result");
	        	if (items && (items.length>0))
	        	{
	        		doc_parsed = true;
	        		var val = trimString(items[0].firstChild.nodeValue)
	        		
	        		
	        		//if (val=="true")
	        		{
	        			doc_loaded = true;
	        			doc = tmp_doc;
	        		}
	        	}
		}
	
		if (doc_parsed==false)
		{
			
			var s = object_context.req.responseText;
			var delimiter1 = "<?xml";
			var delimiter2 = "</is_blogslike>";
			var n1 = s.indexOf(delimiter1);
			
			
			if (n1>=0)
			{
				s = s.substring(n1);
				var n2 = s.lastIndexOf(delimiter2);
				if (n2>0)
				{
					s = s.substring(0,n2+delimiter2.length);
		
					if (typeof DOMParser != 'undefined') 
					{
						var parser = new DOMParser();
						doc = parser.parseFromString(s,"text/xml");
						doc_loaded = true;
					}
					else
					{
						var tmp_doc = new ActiveXObject("Microsoft.XMLDOM");
						 tmp_doc.async=false;
		    				if (tmp_doc.loadXML(s))
		    				{
		    					doc_loaded = true;
		    					doc = tmp_doc;
		    				}					
					}
				}	
			}	
		}
		
		var mess_error="";
		if (doc_loaded)
		{
		
	        	var items = doc.getElementsByTagName("result");
	        	if (items.length>0)
	        	{
	        		var val = trimString(items[0].firstChild.nodeValue)
	        		if (val=="true")
	        		{
	        			object_context.rootDocumentElement = doc;
	        			object_context.success=true;
	        			object_context.slot_finalize(object_context,object_context.optional_args);
	        			
	        			return;
	        		}
	        	}  
	        	
	        	
	        	var errors_st = doc.getElementsByTagName("error");
	        	
	        	if (errors_st.length>0)
	        	{
	        		if (errors_st[0].firstChild!=null)
	        		{
	        			mess_error = trimString(errors_st[0].firstChild.nodeValue)
	        		}
	        	}  	        	
	        	
        	}		
		
		
		
		object_context.error_msg=document.is_global_object.messages.error_retrieving_xml_from_database+"<br>"+mess_error;
	} 
	else
	{
	   object_context.error_msg="There was a problem retrieving the XML data:\n" + object_context.req.statusText;
	} 
	//error
	object_context.slot_finalize(object_context,object_context.optional_args);
	
}

function IS_XmlRequest_generic_processReqChange()
{
	var new_array = Array();
	for (n=0;n<document.IS_array_XmlRequest.length;n++)
	{
		var xml_object = document.IS_array_XmlRequest[n];
		if (xml_object.is_valid)
		{
			
			var valid_object=true;
			if (xml_object.req.readyState == 4)
			{
				
				xml_object.is_valid = false;
				IS_XmlRequest_processReqChange(xml_object);
				valid_object=false;
			}
			if (valid_object==true)
			{
				new_array[new_array.length]=xml_object;
			}
		}
	}
	document.IS_array_XmlRequest = new_array;
}
/////////////////////////////////////////////////////////////////

function IS_postServerData(url,data,fct_slot,optional_args) 
{
	var request = new IS_XmlRequest();
	request.send(url,data,fct_slot,optional_args);
}